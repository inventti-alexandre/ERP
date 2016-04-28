using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceLayer.WorkFlow.Send;

namespace WebApplicationMVC.Areas.WorkFlow.Controllers
{
    public class RecycleController : Controller
    {
        private readonly ISendService _sendService;

        public RecycleController(ISendService sendService)
        {
            _sendService = sendService;
        }

        public ActionResult Index(Guid folid)
        {
            var model = _sendService.LoadRecyclFolder(folid);
            return View(model);
        }
    }
}