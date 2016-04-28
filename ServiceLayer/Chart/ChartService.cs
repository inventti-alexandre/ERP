using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataLayer.Context;
using DomainLayer.App_Model.General;
using DomainLayer.App_Model.JsTree;
using DomainLayer.DB_Model.Chart;
using DomainLayer.DB_Model.EmployeeChart;
using Newtonsoft.Json;
using ServiceLayer.General.Type;
using Type = DomainLayer.DB_Model.General.Type;

namespace ServiceLayer.Chart
{
    public class ChartService : IChartService
    {

        private readonly IDbSet<DomainLayer.DB_Model.Chart.Chart> _chart;
        private readonly ITypeService _typeService;
        private readonly IUnitOfWork _uow;


        public ChartService(IUnitOfWork uow, ITypeService typeService)
        {
            _uow = uow;
            _chart = _uow.Set<DomainLayer.DB_Model.Chart.Chart>();
            _typeService = typeService;


        }



        #region New Chart

        public async Task<ServicesResult> CreateAsync(DomainLayer.DB_Model.Chart.Chart chartModel)
        {
            try
            {
                _chart.Add(chartModel);
                await _uow.SaveChangesAsync();
                return new ServicesResult()
                {
                    ErrorCount = 0,
                    Success = true,
                    Message = "این بخش از چارت سازمانی با موفقیت به سامانه افزوده شد"
                };
            }
            catch (Exception ex)
            {
                return new ServicesResult()
                {
                    Success = false,
                    Message = ex.Message,
                    InnerExeption = ex.InnerException.Message,

                };
               
            }
        }

        public ServicesResult Create(DomainLayer.DB_Model.Chart.Chart chartModel)
        {
            try
            {
                _chart.Add(chartModel);
                 _uow.SaveChanges();
                return new ServicesResult()
                {
                    ErrorCount = 0,
                    Success = true,
                    Message = "این بخش از چارت سازمانی با موفقیت به سامانه افزوده شد"
                };
            }
            catch (Exception ex)
            {
                return new ServicesResult()
                {
                    Success = false,
                    Message = ex.Message,
                    InnerExeption = ex.InnerException.Message,

                };

            }
        }

        #endregion New Chart

        #region Update Chart
        public async Task<ServicesResult> UpdateAsync(DomainLayer.DB_Model.Chart.Chart chartModel)
        {

            try
            {


                _uow.MarkAsChanged(chartModel);
                await _uow.SaveChangesAsync();
                return new ServicesResult()
                {
                    Success = true
                };
            }
            catch (Exception ex)
            {
                return new ServicesResult()
                {
                    Success = false,

                    Message = ex.Message,
                    InnerExeption = ex.InnerException.Message,

                };
            }

        }

        public ServicesResult Update(DomainLayer.DB_Model.Chart.Chart chartModel)
        {
            try
            {


                _uow.MarkAsChanged(chartModel);
                 _uow.SaveChanges();
                return new ServicesResult()
                {
                    Success = true
                };
            }
            catch (Exception ex)
            {
                return new ServicesResult()
                {
                    Success = false,

                    Message = ex.Message,
                    InnerExeption = ex.InnerException.Message,

                };
            }
        }
        #endregion Update Chart

        #region Delete Chart
        public async Task<ServicesResult> DeleteAsync(Guid chartId)
        {
            try
            {

                var news = _chart.Find(chartId);
                _chart.Remove(news);
                await _uow.SaveChangesAsync();
                return new ServicesResult()
                {
                    Success = true
                };

            }
            catch (Exception ex)
            {

                return new ServicesResult()
                {
                    Success = false,
                    Message = ex.Message,
                    InnerExeption = ex.InnerException.Message,

                };
            }
        }

        public ServicesResult Delete(Guid chartId)
        {
            try
            {

                var news = _chart.Find(chartId);
                _chart.Remove(news);
                 _uow.SaveChanges();
                return new ServicesResult()
                {
                    Success = true
                };

            }
            catch (Exception ex)
            {

                return new ServicesResult()
                {
                    Success = false,
                    Message = ex.Message,
                    InnerExeption = ex.InnerException.Message,

                };
            }
        }
        #endregion Delete Chart

        #region Load Chart Data

        public List<DomainLayer.DB_Model.Chart.Chart> LoadChart()
        {

            var charts = _chart.ToList();
            return charts;
        }



        #endregion Load Chart Data

        #region Search On Chart
        public List<DomainLayer.DB_Model.Chart.Chart> FindWithParrentId(Guid? parentId)
        {
            return _chart.Where(w => w.ParentId == parentId).OrderBy(o=>o.Priority).ToList();
        }
        public DomainLayer.DB_Model.Chart.Chart FindWithId(Guid chartId)
        {
            return _chart.Find(chartId);
        }




        #endregion Search On Chart

        #region Folders

       

        public DomainLayer.DB_Model.Chart.Chart GetDepartment(Guid folId)
        {
            var model = _chart.Include(i=>i.Parent).Single(s=>s.ChartId==folId);

            if (model?.Type.Group == (int)ChartEnumerable.ChartGroup.Folders) return model.Parent;

            return null;
        }

        public DomainLayer.DB_Model.Chart.Chart GetFolders(Guid departmentId, ChartEnumerable.FolderType type)
        {
            var model = _chart.Find(departmentId);


           //اگر شناسه جزو ساختار سازمانی بود
            if (model.Type.Group == (int)ChartEnumerable.ChartGroup.ChartLevel)
            {
                return model.Children.Single(s => s.TypeId == (int)type);
            }

            if (model.Type.Group == (int)ChartEnumerable.ChartGroup.Folders)
            {
                return model.Parent.Children.Single(s => s.TypeId == (int)type);
            }

            return null;


        }

        #endregion Folders


        #region GetType
        public async Task<List<Type>> GetChartTypeList()
        {
            return await _typeService.LoadWithGroupIdAsync(1);
        }

     

        #endregion GetType

        #region JsTree

        public string GetTreeJson()
        {
            var nodesList = new List<JsTreeNode>();


            var x = _chart.Single(s => s.ParentId == null);
            var rootNode = new JsTreeNode
            {
                id = x.ChartId.ToString(),
                text = x.Name,
                state = { opened = false },
                
            };

          


            PopulateTree(rootNode);
            nodesList.Add(rootNode);

            return JsonConvert.SerializeObject(nodesList, Formatting.Indented, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize
            });
        }
        private void PopulateTree(JsTreeNode node)
        {


            var mylist = FindWithParrentId(Guid.Parse(node.id));

            

            foreach (var item in mylist)
            {
                if (item.Type.Group == 1)
                {

                    var treeNode = new JsTreeNode
                    {
                        id = item.ChartId.ToString(),
                        state = {opened = false},
                        text = item.Type.Code == 3 ? $"{item.Name} ({item.Employee.Count})" : $"{item.Name}"
                    };


                    PopulateTree(treeNode);
                    node.children.Add(treeNode);
                }
               
            }


        }

        #endregion JsTree

        
    }
}
