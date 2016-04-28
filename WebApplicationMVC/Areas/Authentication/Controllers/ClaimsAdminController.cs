using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ServiceLayer.Authentication.User.Manager;
using WebApplicationMVC.Areas.Authentication.Models;

namespace WebApplicationMVC.Areas.Authentication.Controllers
{
    public class ClaimsAdminController : Controller
    {
        private readonly IApplicationUserManager _userManager;

        public ClaimsAdminController(IApplicationUserManager userManager)
        {
            _userManager = userManager;
        }


        //
        // GET: /Authentication/ClaimsAdmin/
        public async Task<ActionResult> Index(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var user = await _userManager.FindByIdAsync(id.Value);


            ViewBag.Claims = await _userManager.GetClaimsAsync(id.Value);

            return View(user);
        }


        //
        // post: /Authentication/ClaimsAdmin/Delete
        [HttpPost]
        public async Task<ActionResult> Delete(Guid? id, string value, string type)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            var result = await _userManager.RemoveClaimAsync(id.Value, new Claim(type, value));

            if (result.Succeeded)
                return RedirectToActionPermanent("Index", new {id = id.Value});


            return View();
        }


        //
        // GET: /Authentication/ClaimsAdmin/

        public ActionResult Create(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ViewBag.id = id.Value;

            return View();
        }


        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAfterSend(Guid? id, ClaimsCreateViewModel model)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (ModelState.IsValid)
            {
                var claim = new Claim(model.Type, model.Value);

                var result = await _userManager.AddClaimAsync(id.Value, claim);

                if (result.Succeeded)
                    return RedirectToActionPermanent("Index", new {id = id.Value});
            }

            return View();
        }
    }
}