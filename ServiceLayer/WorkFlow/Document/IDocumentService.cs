using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.App_Model.DB_VM;
using DomainLayer.App_Model.General;

namespace ServiceLayer.WorkFlow.Document
{
    public interface IDocumentService
    {


        Task<ServicesResult> CreateNewDocumentAsync(DomainLayer.DB_Model.Documents.Document documents);



        ServicesResult CreateDraftDoc(VmDocDraftSave vmDraftDoc);

        DomainLayer.DB_Model.Documents.Document GetDocument(Guid docId);


        ServicesResult UpdateDocument(VmDocUpdate vmDocUpdate);



        #region DocHistory

        ICollection<DomainLayer.DB_Model.Documents.DocHistory> GetDocumentHistory(Guid docId);

        #endregion DocHistory




    }
}
