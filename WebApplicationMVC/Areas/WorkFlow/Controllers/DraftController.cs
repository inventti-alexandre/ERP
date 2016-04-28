using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using ServiceLayer.WorkFlow.Send;

namespace WebApplicationMVC.Areas.WorkFlow.Controllers
{
    public class DraftController : Controller
    {
        private readonly ISendService _sendService;

        public DraftController(ISendService sendService)
        {
            _sendService = sendService;
        }

        public ActionResult Index(Guid folid)
        {
            var model= _sendService.LoadDraftFolder(folid);
            return View(model);
        }



        [HttpPost]
        public ActionResult MoveToRecyle(List<String> senids)
        {

            var result = _sendService.MoveToRecyle(senids);
            if (result.Success)
            {
                return Json(new { result = result.Message }, JsonRequestBehavior.AllowGet);
            }

            throw new InvalidOperationException($"{result.Message} is not Create.");
        }


    }
}