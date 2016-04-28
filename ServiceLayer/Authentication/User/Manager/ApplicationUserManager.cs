using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using DomainLayer.DB_Model.Authentication;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.DataProtection;
using ServiceLayer.Authentication.Role;
using ServiceLayer.Authentication.Role.Manager;
using ServiceLayer.Properties;

namespace ServiceLayer.Authentication.User.Manager
{
    [UsedImplicitly]
    public class ApplicationUserManager : UserManager<ApplicationUser, Guid>, IApplicationUserManager
    {
        #region Cunstructor

        private readonly IDataProtectionProvider _dataProtectionProvider;
        private readonly IIdentityMessageService _emailService;
        private readonly IApplicationRoleManager _roleManager;
        private readonly IIdentityMessageService _smsService;
        private readonly IUserStore<ApplicationUser, Guid> _store;

        public ApplicationUserManager(
            IUserStore<ApplicationUser, Guid> store,
            IApplicationRoleManager roleManager,
            IDataProtectionProvider dataProtectionProvider,
            IIdentityMessageService smsService,
            IIdentityMessageService emailService) : base(store)
        {
            _store = store;
            _roleManager = roleManager;
            _dataProtectionProvider = dataProtectionProvider;
            _smsService = smsService;
            _emailService = emailService;

            ApplyApplicationUserManagerConfigures();
        }

        #endregion Cunstructor

        #region InterFace IApplicationUserManager

        public Func<CookieValidateIdentityContext, Task> OnValidateIdentity()
        {
            return
                SecurityStampValidator.OnValidateIdentity<ApplicationUserManager, ApplicationUser, Guid>(
                    TimeSpan.FromMinutes(30), GenerateUserIdentityAsync, id => (Guid.Parse(id.GetUserId())));
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(ApplicationUser applicationUser)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            ClaimsIdentity userIdentity =
                await CreateIdentityAsync(applicationUser, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public async Task<bool> HasPassword(Guid userId)
        {
            ApplicationUser user = await FindByIdAsync(userId);
            return user != null && user.PasswordHash != null;
        }

        public async Task<bool> HasPhoneNumber(Guid userId)
        {
            ApplicationUser user = await FindByIdAsync(userId);
            return user != null && user.PhoneNumber != null;
        }

        public async Task<bool> IsCompleteMainInfo(Guid userId)
        {
            ApplicationUser user = await FindByIdAsync(userId);

            return false;
        }

        public void SeedDatabase()
        {
            const string name = "admin@admin.com";
            const string password = "Admin@123456";
            const string roleName = "MainAdmin";

            //Create Role Admin if it does not exist
            ApplicationRole role = _roleManager.FindRoleByName(roleName);
            if (role == null)
            {
                role = new ApplicationRole(roleName,"دسترسی کل سیستم");
                _roleManager.CreateRole(role);
            }

            //Crate Admin User
            ApplicationUser user = this.FindByName(name);
            if (user == null)
            {
                user = new ApplicationUser {UserName = name, Email = name, IsActive = true};
                this.Create(user, password);
                this.SetLockoutEnabled(user.Id, false);
            }

            // Add user admin to Role Admin if not already added
            IList<string> rolesForUser = this.GetRoles(user.Id);
            if (!rolesForUser.Contains(role.Name))
            {
                this.AddToRole(user.Id, role.Name);
            }
        }

        #endregion InterFace IApplicationUserManager

        #region Custom Function

        private void ApplyApplicationUserManagerConfigures()
        {
            // Configure validation logic for usernames
            UserValidator = new UserValidator<ApplicationUser, Guid>(this)
            {
                AllowOnlyAlphanumericUserNames = true,
                RequireUniqueEmail = true
            };

            // Configure validation logic for passwords
            PasswordValidator = new PasswordValidator
            {
                RequiredLength = 3,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = false,
            };

            // Configure user lockout defaults
            UserLockoutEnabledByDefault = true;
            DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
            MaxFailedAccessAttemptsBeforeLockout = 5;

            // Register two factor authentication providers. This application uses Phone and Emails as a step of receiving a code for verifying the user
            // You can write your own provider and plug in here.
            RegisterTwoFactorProvider("PhoneCode", new PhoneNumberTokenProvider<ApplicationUser, Guid>
            {
                MessageFormat = "Your security code is: {0}"
            });
            RegisterTwoFactorProvider("EmailCode", new EmailTokenProvider<ApplicationUser, Guid>
            {
                Subject = "SecurityCode",
                BodyFormat = "Your security code is {0}"
            });
            EmailService = _emailService;
            SmsService = _smsService;

            //if (_dataProtectionProvider != null)
            //{
            //    IDataProtector dataProtector = _dataProtectionProvider.Create("ASP.NET Identity");
            //    UserTokenProvider = new DataProtectorTokenProvider<ApplicationUser, Guid>(dataProtector);
            //}
        }

        #endregion Custom Function

        #region Helper Function

        private async Task<ClaimsIdentity> GenerateUserIdentityAsync(ApplicationUserManager manager,
            ApplicationUser applicationUser)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            ClaimsIdentity userIdentity =
                await manager.CreateIdentityAsync(applicationUser, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        #endregion Helper Function
    }
}