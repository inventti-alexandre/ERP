using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainLayer.DB_Model.Chart;
using Microsoft.AspNet.Identity;
using ServiceLayer.ChartEmployee;
using ServiceLayer.Employee;
using ServiceLayer.Session;

namespace WebApplicationMVC.Areas.WorkFlow.Controllers
{
    public class WorkFlowMainController : Controller
    {


        private readonly IChartEmployeeService _chartEmployeeService;
   

        public WorkFlowMainController(IChartEmployeeService chartEmployeeService
   
            )
        {
            _chartEmployeeService = chartEmployeeService;
           // _sessionProvider = SessionProvider;
        }


        public ActionResult Index()
        {
           
            return View();
        }



        public ActionResult GetFolders()
        {


            var userId =Guid.Parse(User.Identity.GetUserId());

            var employeeChart = _chartEmployeeService.ShowEmployeeCharts(userId);

            return PartialView("_Folders", employeeChart);
        }



    }
}