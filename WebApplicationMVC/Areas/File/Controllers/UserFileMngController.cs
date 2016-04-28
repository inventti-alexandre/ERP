using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceLayer.File;

namespace WebApplicationMVC.Areas.File.Controllers
{
    public class UserFileMngController : Controller
    {

        private readonly IFileService _fileManager;

        public UserFileMngController(IFileService fileProvider)
        {
            _fileManager = fileProvider;
        }


        public ActionResult Upload()
        {

            return View();

        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upload(DomainLayer.DB_Model.File.File fileModel,HttpPostedFile postedFile)
        {

            try
            {

                fileModel.IsActive = true;

                if (postedFile == null)
                {
                    ModelState.AddModelError("","You Select File For Uploading . . . ");
                    return View(fileModel);
                }


                if (ModelState.IsValid)
                {
                    _fileManager.Upload(fileModel);
                }
                else
                {
                    ModelState.AddModelError("","Your File Information Not Valid For Save To DB");
                }
            }
            catch (Exception)
            {
                
                throw;
            }


            return View(fileModel);

        }







    }
}