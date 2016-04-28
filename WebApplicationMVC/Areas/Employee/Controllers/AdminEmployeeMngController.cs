using System;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using ServiceLayer.Employee;
using WebApplicationMVC.Areas.Employee.Models;

namespace WebApplicationMVC.Areas.Employee.Controllers
{
    public class AdminEmployeeMngController : Controller
    {
         private readonly IEmployeeService _employeeService;

      

        public AdminEmployeeMngController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }





        public ActionResult AdminCompleteMainInfo(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AdminCompleteMainInfo(DomainLayer.DB_Model.Employee.Employee model, Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            model.OwnerUserId = Guid.Parse(User.Identity.GetUserId());
            model.AppUserId = id.Value;

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
                    return RedirectToAction("Index", "UsersAdmin", new { @area = "Authentication" });
                }
                ModelState.AddModelError("", "Error In Savin DataBase Please Tell SystemAdministrator");
            }
            else
            {
                ModelState.AddModelError("", "Your Information Not Valid For Save To DataBase Check Again");
            }

            return View(model);
        }


        public ActionResult AdminEditMainInfo(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            var userId = id.Value;
            var employee = _employeeService.Find(userId);
            if (employee == null)
            {
                return RedirectToAction("Index", "UsersAdmin", new { @area = "Authentication" });
            }
            var vmModel = new VMEmployeeEdit()
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                FatherName = employee.FatherName,
                BirthDay = employee.BirthDay,
            };
            return View(vmModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AdminEditMainInfo(VMEmployeeEdit model, Guid? id)
        {
            if (ModelState.IsValid)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }


                var userId = id.Value;
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
                    return RedirectToAction("Index", "UsersAdmin", new { @area = "Authentication" });
                }
                ModelState.AddModelError("", "Error In Savin DataBase Please Tell System Administrator");
            }
            else
            {
                ModelState.AddModelError("", "Your Information Not Valid For Save To DataBase Check Again");
            }

            return View(model);
        }








	}
}