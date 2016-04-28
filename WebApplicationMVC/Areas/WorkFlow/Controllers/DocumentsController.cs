using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using DomainLayer.App_Model.DB_VM;
using DomainLayer.DB_Model.Documents;
using DomainLayer.DB_Model.Send;
using FrameWork.MVC.Utilite;
using Microsoft.AspNet.Identity;
using ServiceLayer.Chart;
using ServiceLayer.Session;
using ServiceLayer.WorkFlow.Document;
using ServiceLayer.WorkFlow.Send;

namespace WebApplicationMVC.Areas.WorkFlow.Controllers
{
    public class DocumentsController : Controller
    {

        private readonly IDocumentService _documentService;
   
        public DocumentsController(IDocumentService documentService)
        {
            _documentService = documentService;
        
        }


        [HttpGet]
        public ActionResult Create(Guid folid)
        {
            return View();
        }

        [HttpPost]
        public ActionResult  SaveDraftDoc(VmDocDraftSave vMDraftDoc)
        {

            var docSaveResult = _documentService.CreateDraftDoc(new VmDocDraftSave()
            {
                Subject = vMDraftDoc.Subject,
                OwnerUserId = Guid.Parse(User.Identity.GetUserId()),
                Content = vMDraftDoc.Content,
                DraftFolderId = vMDraftDoc.DraftFolderId,
           
            });
                
            

            if (docSaveResult.Success)
            {
              
                return Json(new { result = docSaveResult.Data }, JsonRequestBehavior.AllowGet);

            }


            throw new InvalidOperationException($"{docSaveResult.Message} is not Create.");

        }

        [HttpGet]
        public ActionResult ShowDocument(Guid docid)
        {
            var model = _documentService.GetDocument(docid);
            return View(model);
        }

        [HttpGet]
        public ActionResult EditDocument(Guid docid)
        {
            var model = _documentService.GetDocument(docid);
            var vmModel = new VmDocUpdate()
            {
                DocId = model.DocId,
                Subject = model.Subject,
                DocNo = model.DocNo,
                Content = model.Content,
                RegisterDateSh = model.RegisterDateSh,
                
            };

            return View(vmModel);

        }


        [HttpPost]
        public ActionResult EditDocument(VmDocUpdate document,Guid folid)
        {

            document.FolId =folid;
            document.OwnerUserId = Guid.Parse(User.Identity.GetUserId());

            var result=_documentService.UpdateDocument(document);
            if (result.Success)
            {
                return RedirectToAction("ShowDocument", new { @docid = document.DocId });
            }

            ModelState.AddModelError("","اشکال در ویرایش سند");

            return View(document);

        }



    }
}