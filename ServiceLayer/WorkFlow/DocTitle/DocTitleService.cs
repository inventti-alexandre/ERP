using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
using DomainLayer.App_Model.General;
using DomainLayer.DB_Model.Chart;
using DomainLayer.DB_Model.Documents;
using DomainLayer.DB_Model.EmployeeChart;
using DomainLayer.DB_Model.Title;

namespace ServiceLayer.WorkFlow.DocTitle
{
    public class DocTitleService: IDocTitleService
    {

        private readonly IUnitOfWork _uow;

        private readonly IDbSet<DomainLayer.DB_Model.Documents.Document> _document;
        private readonly IDbSet<DomainLayer.DB_Model.Documents.DocHistory> _docHistory;
        private readonly IDbSet<Title> _titles;
        private readonly IDbSet<EmployeeChart> _employeeCharts;
        private readonly IDbSet<DomainLayer.DB_Model.Chart.Chart> _chart;



        public DocTitleService(IUnitOfWork uow)
        {
            _uow = uow;
           
            _document = _uow.Set<DomainLayer.DB_Model.Documents.Document>();
            _titles = _uow.Set<Title>();
            _employeeCharts = _uow.Set<EmployeeChart>();
            _docHistory = _uow.Set<DocHistory>();
            _chart = _uow.Set<DomainLayer.DB_Model.Chart.Chart>();



        }


        public ICollection<EmployeeChart> GetAvalableTitle()
        {
            var model = _employeeCharts.Where(w=>w.IsActive).ToList();
            return model;
        }

        public DomainLayer.DB_Model.Documents.Document GetDocument(Guid docId)
        {
            var model = _document.Find(docId);
            return model;
        }

        public ICollection<Title> GetDocTitles(Guid docid)
        {
            var model = _titles.Where(w => w.DocId == docid && w.IsActive).OrderBy(o=>o.Order).ToList();
            return model;
        }

        public ServicesResult AddDocTitle(IList<Title> titles)
        {
            try
            {

                foreach (var title in titles)
                {
                    _titles.Add(title);
                }

                _uow.SaveChanges();
                return new ServicesResult()
                {
                    Success = true,
                    Message = "Ok"
                };
            }
            catch (Exception ex)
            {

                return new ServicesResult()
                {
                    Success = false,
                    Message = ex.Message,
                    InnerExeption = ex.InnerException.Message
                };
            }
        }

        public ServicesResult RemoveDocTitle(IList<string> titleId,Guid ownerUserId,Guid ownerFolId)
        {
            try
            {


                var depId = _chart.Find(ownerFolId).ParentId ?? ownerFolId;


                foreach (var id in titleId)
                {
                    var model = _titles.Find(Guid.Parse(id));

                    _docHistory.Add(new DocHistory()
                    {
                        DocId = model.DocId,
                        ChangeSet = $"حذف  {model.Type.Subject}  به نام {model.ReceiverDepartment.Name} {model.ReceiverEmployee.FullName} ",
                        OwnerUserId = ownerUserId,
                        OwnerDepartmentId = depId,
                        TypeId = (int)DocHistoryEnumerable.DocHistoryType.RemoveTitle,

                    });

                    _titles.Remove(model);
                }

                _uow.SaveChanges();
                return new ServicesResult()
                {
                    Success = true,
                    Message = "Ok"
                };
            }
            catch (Exception ex)
            {
                return new ServicesResult()
                {
                    Success = false,
                    Message = ex.Message,
                    InnerExeption = ex.InnerException.Message
                };

            }

           

        }

        public int MaxTitleOrder(Guid docId)
        {
            var titles = _titles.Where(w => w.DocId == docId).ToList();
            if (!titles.Any())
            {
                return 0;
            }
            return titles.Max(m=>m.Order);

        }
    }
}
