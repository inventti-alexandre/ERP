using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using ServiceLayer.Authentication.User.Manager;
using ServiceLayer.Employee;
using WebApplicationMVC.Areas.Authentication.Models;
using WebApplicationMVC.Areas.Employee.Models;

namespace WebApplicationMVC.Areas.Employee.Controllers
{
    public class UserEmployeeMngController : Controller
    {
         private readonly IEmployeeService _employeeService;

        public UserEmployeeMngController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
           
        }



        public ActionResult UserCompleteMainInfo()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> UserCompleteMainInfo(DomainLayer.DB_Model.Employee.Employee model)
        {
            model.OwnerUserId = Guid.Parse(User.Identity.GetUserId());
            model.AppUserId = Guid.Parse(User.Identity.GetUserId());

            HttpPostedFileBase photo = Request.Files["pictureFile"];

            if (photo != null && photo.ContentLength > 0)
            {
                using (var reader = new System.IO.BinaryReader(photo.InputStream))
                {
                    model.Picture = reader.ReadBytes(photo.ContentLength);
                }
            }


            if (ModelState.IsValid)
            {

                var result = await _employeeService.CreateAsync(model);
                if (result.Success)
                {
                    return RedirectToAction("Index", "Manage",
                        new { @area = "Authentication", Message = ManageMessageId.CompleteMainInfo });
                }
                ModelState.AddModelError("", "Error In Savin DataBase Please Tell SystemAdministrator");
            }
            else
            {
                ModelState.AddModelError("", "Your Information Not Valid For Save To DataBase Check Again");
            }

            return View(model);
        }


        public ActionResult UserEditMainInfo()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var employee = _employeeService.Find(userId);

            if (employee == null)
            {
                return RedirectToAction("Index", "Manage", new { @area = "Authentication" });
            }
            var vmModel = new VMEmployeeEdit()
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                FatherName = employee.FatherName,
                BirthDay = employee.BirthDay,
                Image = employee.Picture,
            };
            return View(vmModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> UserEditMainInfo(VMEmployeeEdit model)
        {
            if (ModelState.IsValid)
            {
                var userId = Guid.Parse(User.Identity.GetUserId());
                var employee = _employeeService.Find(userId);

                employee.FirstName = model.FirstName;
                employee.LastName = model.LastName;
                employee.FatherName = model.FatherName;
                employee.BirthDay = model.BirthDay;

                HttpPostedFileBase photo = Request.Files["pictureFile"];

                if (photo != null && photo.ContentLength > 0)
                {
                    using (var reader = new System.IO.BinaryReader(photo.InputStream))
                    {
                        employee.Picture = reader.ReadBytes(photo.ContentLength);
                    }
                }



                var result = await _employeeService.UpdateAsync(employee);
                if (result.Success)
                {
                    return RedirectToAction("Index", "Manage",
                        new { @area = "Authentication", Message = ManageMessageId.CompleteMainInfo });
                }
                ModelState.AddModelError("", "Error In Savin DataBase Please Tell SystemAdministrator");
            }
            else
            {
                ModelState.AddModelError("", "Your Information Not Valid For Save To DataBase Check Again");
            }

            return View(model);
        }



     


    }
}