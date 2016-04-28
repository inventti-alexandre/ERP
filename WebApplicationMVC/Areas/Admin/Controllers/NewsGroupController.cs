using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using DomainLayer.DB_Model.News;
using Microsoft.AspNet.Identity;
using ServiceLayer.News;

namespace WebApplicationMVC.Areas.Admin.Controllers
{
    public class NewsGroupController : Controller
    {


        private readonly INewsGroupServices _newsGroupServices;

        public NewsGroupController(INewsGroupServices newsGroupServices)
        {
            _newsGroupServices = newsGroupServices;
        }


        public ActionResult index()
        {
          
            return View(_newsGroupServices.GetGroupList());
        }


        public ActionResult Create()
        {
            var model = new NewsGroup()
            {
                IsActive = true,
            };

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(NewsGroup newsgroup)
        {

            if (ModelState.IsValid)
            {

                newsgroup.OwnerUserId = Guid.Parse(User.Identity.GetUserId());

                
                var result = await _newsGroupServices.CreateNewGroupAsync(newsgroup);
                if (result.Success)
                {
                    return RedirectToAction("Index", "NewsGroup", new { @area = "Admin" });
                }
                ModelState.AddModelError("", "Error In Savin DataBase Please Tell SystemAdministrator");
            }
            else
            {
                ModelState.AddModelError("", "Your Information Not Valid For Save To DataBase Check Again");
               
            }

            return View(newsgroup);
            
        }


    }
}