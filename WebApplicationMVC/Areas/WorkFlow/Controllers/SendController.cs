using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DomainLayer.App_Model.DB_VM;
using DomainLayer.DB_Model.Documents;
using Microsoft.AspNet.Identity;
using ServiceLayer.ChartEmployee;
using ServiceLayer.WorkFlow.DocSend;
using ServiceLayer.WorkFlow.Document;

namespace WebApplicationMVC.Areas.WorkFlow.Controllers
{
    public class SendController : Controller
    {


        private readonly IDocSendService _docSendService;



        public SendController(IDocSendService sendProxy)
        {
            _docSendService = sendProxy;
        }


        [HttpGet]
        public ActionResult SendDocument(string docId, Guid folId)
        {

            var dcoIds = docId.Split(Convert.ToChar(","));

            var senPageModel = new VmDocSend
            {
                Documents = _docSendService.GetReadyDocumentsForSend(dcoIds.ToList()),
                AvalableReceiver = _docSendService.GetAvalablEmployeeForSend()
            };





            return View(senPageModel);
        }


        [HttpPost]
        public  ActionResult SendDocument(VmDocSendPost docSendModel )
        {

            if (Request.IsAjaxRequest())
            {

                docSendModel.OwnerUserId = User.Identity.GetUserId();

                var result= _docSendService.SendDocuments(docSendModel);
                if (result.Success)
                {
                    return Json(new {result = "ok"}, JsonRequestBehavior.AllowGet);
                }
               
                    throw new InvalidOperationException($"Server Error : {result.Message}");
            }

            throw new InvalidOperationException(" is not Valid Method Type Method Is Ajax ");

        }
    }
}