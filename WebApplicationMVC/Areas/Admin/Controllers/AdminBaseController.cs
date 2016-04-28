using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVC.Areas.Admin.Controllers
{
    public class AdminBaseController : Controller
    {
        //
        // GET: /Admin/Index/
        public ActionResult Index()
        {
            return View();
        }
	}
}