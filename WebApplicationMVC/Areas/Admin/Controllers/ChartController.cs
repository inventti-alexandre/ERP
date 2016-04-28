using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DomainLayer.App_Model.General;
using DomainLayer.App_Model.JsTree;
using DomainLayer.DB_Model.Chart;
using Newtonsoft.Json;
using ServiceLayer.Chart;
using ServiceLayer.General.Type;

namespace WebApplicationMVC.Areas.Admin.Controllers
{
    public class ChartController : Controller
    {


        private readonly IChartService _chartServices;
       


        public ChartController(IChartService chartService)
        {
            _chartServices = chartService;
          

        }

        public async Task<ActionResult> Index()
        {

            var TypeIdGroupList = new SelectList(await _chartServices.GetChartTypeList(), "TypeId", "Subject");
            ViewBag.TypeIdGroupList = TypeIdGroupList;

            return View();
        }


        #region Js Request

        [HttpPost]
        public string GetTreeJson()
        {
            return _chartServices.GetTreeJson();
        }

        [HttpPost]
        public ActionResult DoJsTreeOperation(JsTreeOperationData data)
        {


            ServicesResult result;
            Chart model;

            switch (data.Operation)
            {

                case JsTreeOperation.CreateNode:

                    Guid id;
                    Guid.TryParse(data.Id, out id);
                    if (id == Guid.Empty)
                    {
                        id = Guid.NewGuid();
                        return Json(new { id = id }, JsonRequestBehavior.AllowGet);
                    }


                    var newChart = new Chart()
                    {
                        ChartId = id,
                        ParentId = Guid.Parse(data.ParentId),
                        Name = data.Text,
                        TypeId =int.Parse(data.TypeId),
                        IsActive = true,
                    };

                   
                    //اگر زیرشاخه از نوع سمت بود زیر شاخه های پیش فرض را به آن اضافه میکنیم
                    if (int.Parse(data.TypeId) == 3)
                    {
                        var ChartList = new List<Chart>()
                        {
                            new Chart()
                            {
                                ChartId = Guid.NewGuid(),
                                ParentId = newChart.ChartId,
                                Name = "کارتابل",
                                TypeId = 4,
                                IsActive = true,
                            },
                            new Chart()
                            {
                                ChartId = Guid.NewGuid(),
                                ParentId = newChart.ChartId,
                                Name = "بازیافت",
                                TypeId = 5,
                                IsActive = true,
                            },
                            new Chart()
                            {
                                ChartId = Guid.NewGuid(),
                                ParentId = newChart.ChartId,
                                Name = "پیش نویس",
                                TypeId = 6,
                                IsActive = true,
                            }

                        };

                        newChart.Children = ChartList;


                    }

                    result = _chartServices.Create(newChart);
                    if (result.Success)
                    {
                        return Json(new { result = "ok" }, JsonRequestBehavior.AllowGet);
                    }

                    throw new InvalidOperationException($"{data.Text} is not Create.");

                case JsTreeOperation.DeleteNode:

                    result = _chartServices.Delete(Guid.Parse(data.Id));

                    if (result.Success)
                    {
                        return Json(new { result = "ok" }, JsonRequestBehavior.AllowGet);
                    }
                    throw new InvalidOperationException($"{data.Text} is not Remove.");

                case JsTreeOperation.MoveNode:


                    model = _chartServices.FindWithId(Guid.Parse(data.Id));
                    model.ParentId = Guid.Parse(data.ParentId);
                    result = _chartServices.Update(model);
                    if (result.Success)
                    {
                        return Json(new { result = "ok" }, JsonRequestBehavior.AllowGet);
                    }
                    throw new InvalidOperationException($"{data.Text} is not Updated.");




                case JsTreeOperation.RenameNode:

                    Guid Nodeid;
                    Guid.TryParse(data.Id, out Nodeid);
                    if (Nodeid == Guid.Empty)
                    {
                        return Json(new { isTrueRename = false }, JsonRequestBehavior.AllowGet);
                    }

                    model = _chartServices.FindWithId(Guid.Parse(data.Id));
                    model.Name = data.Text.Trim();
                    result = _chartServices.Update(model);
                    if (result.Success)
                    {
                        return Json(new { isTrueRename = true }, JsonRequestBehavior.AllowGet);
                    }
                    throw new InvalidOperationException($"{data.Text} is not Updated.");



                default:
                    throw new InvalidOperationException($"{data.Operation} is not supported.");
            }


        }

        #endregion Js Request





    }
}