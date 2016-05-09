using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainLayer.App_Model.DB_VM;
using DomainLayer.DB_Model.Title;
using Microsoft.AspNet.Identity;
using ServiceLayer.WorkFlow.DocTitle;
using ServiceLayer.WorkFlow.Document;

namespace WebApplicationMVC.Areas.WorkFlow.Controllers
{
    public class TitleController : Controller
    {




        private readonly IDocTitleService _titleService;

        public TitleController(IDocTitleService titleService)
        {

            _titleService = titleService;
        }


        public ActionResult Index(Guid docId, Guid folId)
        {


            var vmTitle = new VmDocTitle()
            {
                Document = _titleService.GetDocument(docId),
                AvalableTitle = _titleService.GetAvalableTitle(),
                SelectedTitle = _titleService.GetDocTitles(docId),
            };

            return View(vmTitle);
        }



        [HttpPost]
        public ActionResult AddTitle(VmDocTitlePost docTitleModel)
        {
            if (Request.IsAjaxRequest())
            {

                docTitleModel.OwnerUserId = User.Identity.GetUserId();

               
                var titleList= docTitleModel.Titles.Select(title => new Title()
                {
                    DocId = Guid.Parse(docTitleModel.DocId), Order = 0, OwnerUserId = Guid.Parse(docTitleModel.OwnerUserId), ReceiverDepartmentId = Guid.Parse(title.ReceiverFolIds), ReceiverEmployeeId = Guid.Parse(title.ReceiverPrsId), TypeId = docTitleModel.TypeId, Name = "",
                }).ToList();

                var result=_titleService.AddDocTitle(titleList);
                if (result.Success)
                {
                    return Json(new { result = "ok" }, JsonRequestBehavior.AllowGet);
                }
              
                throw new InvalidOperationException($"Server error Is : {result.Message} Inner Error {result.InnerExeption}");
                
            }

            throw new InvalidOperationException(" is not Valid Method Type Method Is Ajax ");

        }
    }

}