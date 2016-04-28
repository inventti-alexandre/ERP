using ServiceLayer.ChartEmployee;
using ServiceLayer.WorkFlow.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.DB_Model.Documents;
using DomainLayer.DB_Model.EmployeeChart;

namespace ProxyLayer.WorkFlow
{



   
    public class SendDocumentProxy : ISendDocumentProxy
    {
        private readonly IDocumentService _documentService;
        private readonly IChartEmployeeService _chartEmployeeService;

        public SendDocumentProxy(IDocumentService documentService, IChartEmployeeService chartEmployeeService)
        {
            _documentService = documentService;
            _chartEmployeeService = chartEmployeeService;
        }


        public ICollection<Document> GetReadyDocumentsForSend(IList<string> docIds)
        {
            return docIds.Select(docid => _documentService.GetDocument(Guid.Parse(docid))).ToList();
        }

        public ICollection<EmployeeChart> GetAvalablEmployeeForSend()
        {
            return _chartEmployeeService.ShowAll();
        }
    }
}
