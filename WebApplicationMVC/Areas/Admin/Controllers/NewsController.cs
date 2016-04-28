using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using ServiceLayer.News;

namespace WebApplicationMVC.Areas.Admin.Controllers
{
    public class NewsController : Controller
    {


        private readonly INewsServices _newsServices;
        private readonly INewsGroupServices _newsGroupServices;


        public NewsController(INewsServices newsServices, INewsGroupServices newsGroupServices)
        {
            _newsServices = newsServices;
            _newsGroupServices = newsGroupServices;
        }



        #region News


        [HttpGet]
        public ActionResult Index()
        {


            var model = _newsServices.GetNewsList();
            return View(model);

        }


        [HttpGet]
        public ActionResult Create()
        {

            var DefoultModel = new DomainLayer.DB_Model.News.News
            {
                IsActive = true
            };


            var NewsGroupList = new SelectList(_newsGroupServices.GetGroupList(), "NewsGroupId", "Name");

            ViewBag.NewsGroupList = NewsGroupList;

            return View(DefoultModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(DomainLayer.DB_Model.News.News newsModel)
        {

            if (ModelState.IsValid)
            {

                newsModel.OwnerUserId = Guid.Parse(User.Identity.GetUserId());
                var result = await _newsServices.CreateNewsAsync(newsModel);
                if (result.Success)
                {
                    return RedirectToAction("Index", "News", new { @area = "News" });
                }

                ModelState.AddModelError("", "Error In Savin DataBase Please Tell SystemAdministrator");
            }
            else
            {
                ModelState.AddModelError("", "Your Information Not Valid For Save To DataBase Check Again");

            }

            return View(newsModel);
        }




        [HttpGet]
        public ActionResult Update(Guid id)
        {

            var model = _newsServices.Find(id);


            var NewsGroupList = new SelectList(_newsGroupServices.GetGroupList(), "NewsGroupId", "Name");
            ViewBag.NewsGroupList = NewsGroupList;

            return View(model);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Update(DomainLayer.DB_Model.News.News news)
        {




            var result = await _newsServices.UpdateAsync(news);

            if (result.Success)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", string.Format("Update Invalid Error Is {0}", result.InnerExeption));
            return View(news);

        }




        [HttpGet]
        public ActionResult Delete(Guid? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            var model = _newsServices.Find((Guid)id);
            if (model == null)
            {
                return HttpNotFound();
            }


            return View(model);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<ActionResult> DeleteConferm(Guid? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var news = _newsServices.Find((Guid) id);
            if (news == null)
            {
                return HttpNotFound();
            }
            
            var result=await _newsServices.DeleteAsync(news.NewsId);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", string.Format("Update Invalid Error Is {0}", result.InnerExeption));
            return View(news);

        }

        #endregion News

       


    }
}