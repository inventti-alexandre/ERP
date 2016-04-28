using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using FrameWork.MVC.Authenticate.Filter;
using Microsoft.AspNet.Identity.Owin;


namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
                return View();
        }


        public ActionResult About()
        {
            return View();
        }


        [ClaimsAccess(Value = "test")]
        public ActionResult Contact()
        {
            return View();
        }
    }
}