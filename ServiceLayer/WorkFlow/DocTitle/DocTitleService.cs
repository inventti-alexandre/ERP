using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
using DomainLayer.App_Model.General;
using DomainLayer.DB_Model.EmployeeChart;
using DomainLayer.DB_Model.Title;

namespace ServiceLayer.WorkFlow.DocTitle
{
    public class DocTitleService: IDocTitleService
    {

        private readonly IUnitOfWork _uow;

        private readonly IDbSet<DomainLayer.DB_Model.Documents.Document> _document;
        private readonly IDbSet<DomainLayer.DB_Model.Title.Title> _titles;
        private readonly IDbSet<DomainLayer.DB_Model.EmployeeChart.EmployeeChart> _employeeCharts;



        public DocTitleService(IUnitOfWork uow)
        {
            _uow = uow;
            _document = _uow.Set<DomainLayer.DB_Model.Documents.Document>();
            _titles = _uow.Set<DomainLayer.DB_Model.Title.Title>();
            _employeeCharts = _uow.Set<DomainLayer.DB_Model.EmployeeChart.EmployeeChart>();



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
            var model = _titles.Where(w => w.DocId == docid && w.IsActive).OrderBy(o=>o.TypeId).ToList();
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
    }
}
