using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using DomainLayer.DB_Model.Authentication;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using ServiceLayer.Authentication.User.Manager;
using ServiceLayer.Employee;
using WebApplicationMVC.Areas.Authentication.Helper;
using WebApplicationMVC.Areas.Authentication.Models;

namespace WebApplicationMVC.Areas.Authentication.Controllers
{
    [Authorize]
    public class ManageController : Controller
    {
        // Used for XSRF protection when adding external logins
        private const string XsrfKey = "XsrfId";

        private readonly IAuthenticationManager _authenticationManager;
        private readonly IApplicationUserManager _userManager;
        private readonly IEmployeeService _employeeService;

        public ManageController(IApplicationUserManager userManager, IAuthenticationManager authenticationManager,
            IEmployeeService employeeService)
        {
            _userManager = userManager;
            _authenticationManager = authenticationManager;
            _employeeService = employeeService;
        }


        public async Task<ActionResult> Index(ManageMessageId? message)
        {
            ViewBag.StatusMessage =
                message == ManageMessageId.ChangePasswordSuccess
                    ? "Your password has been changed."
                    : message == ManageMessageId.SetPasswordSuccess
                        ? "Your password has been set."
                        : message == ManageMessageId.SetTwoFactorSuccess
                            ? "Your two factor provider has been set."
                            : message == ManageMessageId.Error
                                ? "An error has occurred."
                                : message == ManageMessageId.AddPhoneSuccess
                                    ? "The phone number was added."
                                    : message == ManageMessageId.RemovePhoneSuccess
                                        ? "Your phone number was removed."
                                        : message == ManageMessageId.CompleteMainInfo
                                            ? "Your Main Personnal Information Completed"
                                            : "";

            var userId = Guid.Parse(User.Identity.GetUserId());
            var model = new IndexViewModel
            {
                HasPassword = await _userManager.HasPassword(userId),
                PhoneNumber = await _userManager.GetPhoneNumberAsync(userId),
                TwoFactor = await _userManager.GetTwoFactorEnabledAsync(userId),
                Logins = await _userManager.GetLoginsAsync(userId),
                BrowserRemembered = await _authenticationManager.TwoFactorBrowserRememberedAsync(userId.ToString()),
                IsCompleteMainInfo = await _employeeService.IsCompletMainInfo(userId),
            };
            return View(model);
        }


        public ActionResult AddPhoneNumber()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddPhoneNumber(AddPhoneNumberViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            // Generate the token and send it
            var code =
                await
                    _userManager.GenerateChangePhoneNumberTokenAsync(Guid.Parse(User.Identity.GetUserId()), model.Number);
            if (_userManager.SmsService != null)
            {
                var message = new IdentityMessage
                {
                    Destination = model.Number,
                    Body = "Your security code is: " + code
                };
                await _userManager.SmsService.SendAsync(message);
            }
            return RedirectToAction("VerifyPhoneNumber", new {PhoneNumber = model.Number});
        }


        public ActionResult ChangePassword()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result =
                await
                    _userManager.ChangePasswordAsync(Guid.Parse(User.Identity.GetUserId()), model.OldPassword,
                        model.NewPassword);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByIdAsync(Guid.Parse(User.Identity.GetUserId()));
                if (user != null)
                {
                    await SignInAsync(user, isPersistent: false);
                }
                return RedirectToAction("Index", new {Message = ManageMessageId.ChangePasswordSuccess});
            }
            AddErrors(result);
            return View(model);
        }


        [HttpPost]
        public async Task<ActionResult> DisableTFA()
        {
            await _userManager.SetTwoFactorEnabledAsync(Guid.Parse(User.Identity.GetUserId()), false);
            var user = await _userManager.FindByIdAsync(Guid.Parse(User.Identity.GetUserId()));
            if (user != null)
            {
                await SignInAsync(user, isPersistent: false);
            }
            return RedirectToAction("Index", "Manage", new {@area = "Authentication"});
        }


        [HttpPost]
        public async Task<ActionResult> EnableTFA()
        {
            await _userManager.SetTwoFactorEnabledAsync(Guid.Parse(User.Identity.GetUserId()), true);
            var user = await _userManager.FindByIdAsync(Guid.Parse(User.Identity.GetUserId()));
            if (user != null)
            {
                await SignInAsync(user, isPersistent: false);
            }
            return RedirectToAction("Index", "Manage", new {@area = "Authentication"});
        }


        [HttpPost]
        public ActionResult ForgetBrowser()
        {
            _authenticationManager.SignOut(DefaultAuthenticationTypes.TwoFactorRememberBrowserCookie);
            return RedirectToAction("Index", "Manage", new {@area = "Authentication"});
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LinkLogin(string provider)
        {
            // Request a redirect to the external login provider to link a login for the current user
            return new ChallengeResult(provider, Url.Action("LinkLoginCallback", "Manage"), User.Identity.GetUserId());
        }


        public async Task<ActionResult> LinkLoginCallback()
        {
            var loginInfo = await _authenticationManager.GetExternalLoginInfoAsync(XsrfKey, User.Identity.GetUserId());
            if (loginInfo == null)
            {
                return RedirectToAction("ManageLogins", new {Message = ManageMessageId.Error});
            }
            var result = await _userManager.AddLoginAsync(Guid.Parse(User.Identity.GetUserId()), loginInfo.Login);
            return result.Succeeded
                ? RedirectToAction("ManageLogins")
                : RedirectToAction("ManageLogins", new {Message = ManageMessageId.Error});
        }


        public async Task<ActionResult> ManageLogins(ManageMessageId? message)
        {
            ViewBag.StatusMessage =
                message == ManageMessageId.RemoveLoginSuccess
                    ? "The external login was removed."
                    : message == ManageMessageId.Error
                        ? "An error has occurred."
                        : "";
            var user = await _userManager.FindByIdAsync(Guid.Parse(User.Identity.GetUserId()));
            if (user == null)
            {
                return View("Error");
            }
            var userLogins = await _userManager.GetLoginsAsync(Guid.Parse(User.Identity.GetUserId()));
            var otherLogins =
                _authenticationManager.GetExternalAuthenticationTypes()
                    .Where(auth => userLogins.All(ul => auth.AuthenticationType != ul.LoginProvider))
                    .ToList();
            ViewBag.ShowRemoveButton = user.PasswordHash != null || userLogins.Count > 1;
            return View(new ManageLoginsViewModel
            {
                CurrentLogins = userLogins,
                OtherLogins = otherLogins
            });
        }


        [HttpPost]
        public ActionResult RememberBrowser()
        {
            var rememberBrowserIdentity =
                _authenticationManager.CreateTwoFactorRememberBrowserIdentity(User.Identity.GetUserId());
            _authenticationManager.SignIn(new AuthenticationProperties {IsPersistent = true}, rememberBrowserIdentity);
            return RedirectToAction("Index", "Manage", new {@area = "Authentication"});
        }


        public async Task<ActionResult> RemoveLogin()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var linkedAccounts = await _userManager.GetLoginsAsync(userId);
            ViewBag.ShowRemoveButton = await _userManager.HasPassword(userId) || linkedAccounts.Count > 1;
            return View(linkedAccounts);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RemoveLogin(string loginProvider, string providerKey)
        {
            ManageMessageId? message;
            var result =
                await
                    _userManager.RemoveLoginAsync(Guid.Parse(User.Identity.GetUserId()),
                        new UserLoginInfo(loginProvider, providerKey));
            if (result.Succeeded)
            {
                var user = await _userManager.FindByIdAsync(Guid.Parse(User.Identity.GetUserId()));
                if (user != null)
                {
                    await SignInAsync(user, isPersistent: false);
                }
                message = ManageMessageId.RemoveLoginSuccess;
            }
            else
            {
                message = ManageMessageId.Error;
            }
            return RedirectToAction("ManageLogins", new {Message = message});
        }


        public async Task<ActionResult> RemovePhoneNumber()
        {
            var result = await _userManager.SetPhoneNumberAsync(Guid.Parse(User.Identity.GetUserId()), null);
            if (!result.Succeeded)
            {
                return RedirectToAction("Index", new {Message = ManageMessageId.Error});
            }
            var user = await _userManager.FindByIdAsync(Guid.Parse(User.Identity.GetUserId()));
            if (user != null)
            {
                await SignInAsync(user, isPersistent: false);
            }
            return RedirectToAction("Index", new {Message = ManageMessageId.RemovePhoneSuccess});
        }


        public ActionResult SetPassword()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SetPassword(SetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result =
                    await _userManager.AddPasswordAsync(Guid.Parse(User.Identity.GetUserId()), model.NewPassword);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByIdAsync(Guid.Parse(User.Identity.GetUserId()));
                    if (user != null)
                    {
                        await SignInAsync(user, isPersistent: false);
                    }
                    return RedirectToAction("Index", new {Message = ManageMessageId.SetPasswordSuccess});
                }
                AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }


        public async Task<ActionResult> VerifyPhoneNumber(string phoneNumber)
        {
            // This code allows you exercise the flow without actually sending codes
            // For production use please register a SMS provider in IdentityConfig and generate a code here.
            var code =
                await
                    _userManager.GenerateChangePhoneNumberTokenAsync(Guid.Parse(User.Identity.GetUserId()), phoneNumber);
            ViewBag.Status = "For DEMO purposes only, the current code is " + code;
            return phoneNumber == null
                ? View("Error")
                : View(new VerifyPhoneNumberViewModel {PhoneNumber = phoneNumber});
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> VerifyPhoneNumber(VerifyPhoneNumberViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result =
                await
                    _userManager.ChangePhoneNumberAsync(Guid.Parse(User.Identity.GetUserId()), model.PhoneNumber,
                        model.Code);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByIdAsync(Guid.Parse(User.Identity.GetUserId()));
                if (user != null)
                {
                    await SignInAsync(user, isPersistent: false);
                }
                return RedirectToAction("Index", new {Message = ManageMessageId.AddPhoneSuccess});
            }
            // If we got this far, something failed, redisplay form
            ModelState.AddModelError("", "Failed to verify phone");
            return View(model);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        private async Task SignInAsync(ApplicationUser user, bool isPersistent)
        {
            _authenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie,
                DefaultAuthenticationTypes.TwoFactorCookie);
            _authenticationManager.SignIn(new AuthenticationProperties {IsPersistent = isPersistent},
                await _userManager.GenerateUserIdentityAsync(user));
        }
    }
}