
using ServiceLayer.Chart;
using ServiceLayer.ChartEmployee;
using ServiceLayer.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace WebApplicationMVC.Areas.Admin.Controllers
{
    public class ChartEmployeController : Controller
    {



        private readonly IChartService _chartServices;
        private readonly IEmployeeService _employeeServices;
        private readonly IChartEmployeeService _chartEmployeeService;


        public ChartEmployeController(IChartEmployeeService chartEmployee, IChartService chartService, IEmployeeService employeeService)
        {
            _chartServices = chartService;
            _employeeServices = employeeService;
            _chartEmployeeService = chartEmployee;

        }

   

        //افزودن یک پرسنل به قسمت انخاب شده از چارت
        public ActionResult NewChartEmployee(Guid chartid)
        {

            var chart = _chartServices.FindWithId(chartid);
            ViewBag.ChartName = chart.Name;
            ViewBag.ChartId = chart.ChartId;

            var employee = _employeeServices.GetAllEmployees();


            return View(employee);
        }

        //نمایش لیست پرسنل های منصوب شده به قسمت انتخابی از پارت
        public ActionResult ListChartEmployees(Guid chartid)
        {

            var chart = _chartServices.FindWithId(chartid);
            ViewBag.ChartName = chart.Name;
            ViewBag.ChartId = chart.ChartId;

            var model=_chartEmployeeService.ShowChartEmployees(chartid);

           

            return View(model);
        }

        #region Partial Render View

        [Authorize]
        public ActionResult EmployeeChartDropDown()
        {
            var model = _chartEmployeeService.ShowEmployeeCharts(Guid.Parse(User.Identity.GetUserId()));
            return PartialView(model);
        }


        #endregion Partial Render View



        #region Ajax Request

       [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> JoinEmployeeToChart(string chartid, string employeeId)
        {

            if (Request.IsAjaxRequest())
            {


                var result = await _chartEmployeeService.JoinPrsToChart(Guid.Parse(employeeId), Guid.Parse(chartid));
                if (result.Success)
                {
                    return Json(new { result = "ok" }, JsonRequestBehavior.AllowGet);
                }

                throw new InvalidOperationException(" is Not Save Employee To Chart ");

            }

            throw new InvalidOperationException(" is not Valid Method Type Method Is Ajax ");

        }

        [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> DisableEmployeeOfChart(string chartid, string employeeId)
        {
            if (Request.IsAjaxRequest())
            {


                var result = await _chartEmployeeService.DisablePrsFromChart(Guid.Parse(employeeId),Guid.Parse(chartid));
                if (result.Success)
                {
                    return Json(new { result = "ok" }, JsonRequestBehavior.AllowGet);
                }

                throw new InvalidOperationException(" is Not Save Employee To Chart ");

            }

            throw new InvalidOperationException(" is not Valid Method Type Method Is Ajax ");
        }


        public async System.Threading.Tasks.Task<ActionResult> EnableEmployeeOfChart(string chartid, string employeeId)
        {
            if (Request.IsAjaxRequest())
            {


                var result = await _chartEmployeeService.EnablePrsFromChart(Guid.Parse(employeeId), Guid.Parse(chartid));
                if (result.Success)
                {
                    return Json(new { result = "ok" }, JsonRequestBehavior.AllowGet);
                }

                throw new InvalidOperationException(" is Not Save Employee To Chart ");

            }

            throw new InvalidOperationException(" is not Valid Method Type Method Is Ajax ");
        }

        #endregion Ajax Request

    }
}