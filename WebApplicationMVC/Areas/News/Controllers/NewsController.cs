using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceLayer.News;

namespace WebApplicationMVC.Areas.News.Controllers
{
    public class NewsController : Controller
    {


        private readonly INewsServices _newsService ;
        public NewsController(INewsServices newsServices)
        {
            _newsService = newsServices;
        }


        [HttpGet]
        public ActionResult Index()
        {

            var newsList = _newsService.GetNewsList(NewsServices.ListMode.ActiveNews);
            return View(newsList);
        }
	}
}