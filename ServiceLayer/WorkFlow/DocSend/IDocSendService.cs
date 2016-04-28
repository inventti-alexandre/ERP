using System.Collections.Generic;
using System.Threading.Tasks;
using DomainLayer.App_Model.DB_VM;
using DomainLayer.App_Model.General;
using DomainLayer.DB_Model.EmployeeChart;

namespace ServiceLayer.WorkFlow.DocSend
{
    public interface IDocSendService
    {



        ICollection<DomainLayer.DB_Model.Documents.Document> GetReadyDocumentsForSend(IList<string> docIds);

        ICollection<EmployeeChart> GetAvalablEmployeeForSend();



        ServicesResult SendDocuments(VmDocSendPost docSendmodel);


    }
}