using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using DataLayer.Context;
using DomainLayer.App_Model.DB_VM;
using DomainLayer.App_Model.General;
using DomainLayer.DB_Model.Documents;
using ServiceLayer.Chart;

namespace ServiceLayer.WorkFlow.Document
{
    public class DocumentService:IDocumentService
    {

        private readonly IDbSet<DomainLayer.DB_Model.Documents.Document> _document;
        private readonly IDbSet<DomainLayer.DB_Model.Send.Send> _send;
        private readonly IDbSet<DomainLayer.DB_Model.Documents.DocHistory> _docHistory;

        private readonly IChartService _chartService;


        private readonly IUnitOfWork _uow;


        public DocumentService(IUnitOfWork uow, IChartService chartService)
        {
            _uow = uow;
            _chartService = chartService;
            _docHistory = _uow.Set<DocHistory>(); ;
            _send = _uow.Set<DomainLayer.DB_Model.Send.Send>();
            _document = _uow.Set<DomainLayer.DB_Model.Documents.Document>();
        }



        public async Task<ServicesResult> CreateNewDocumentAsync(DomainLayer.DB_Model.Documents.Document documents)
        {
            try
            {

                _document.Add(documents);

                await _uow.SaveChangesAsync();
                return new ServicesResult()
                {
                    Success = true,
                    Data = documents.DocNo
                    
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
            
            
            
            //throw new NotImplementedException();
        }

        public  ServicesResult CreateDraftDoc(VmDocDraftSave vmDraftDoc)
        {


            try
            {
                var ownerUserId = vmDraftDoc.OwnerUserId;

                Guid senderDepartmentId = _chartService.GetDepartment(vmDraftDoc.DraftFolderId).ChartId;
                Guid receverDepartmentId = senderDepartmentId;



                //درج خود سند
                var document = new DomainLayer.DB_Model.Documents.Document
                {
                    OwnerUserId = ownerUserId,
                    Subject = vmDraftDoc.Subject,
                    Content = vmDraftDoc.Content,
                };

                _document.Add(document);

                //درج گردش سند برای نمایش سند در ‍پوشه پیشنویس
                var send = new DomainLayer.DB_Model.Send.Send()
                {
                    DocId = document.DocId,
                    OwnerUserId = ownerUserId,
                    //محل سند
                    FolderId = vmDraftDoc.DraftFolderId,
                    ReceverEmployeeId = ownerUserId,
                    SenderEmployeeId = ownerUserId,
                    ReceverDepartmentId =  receverDepartmentId,
                    SenderDepartmentId = senderDepartmentId,
                    SendDescription = "تایپ سند جدید"
                };

                _send.Add(send);


                _uow.SaveChanges();

                return new ServicesResult()
                {
                    Success = true,
                    Data = new { docNo = document.DocNo, docId = document.DocId },

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

        public DomainLayer.DB_Model.Documents.Document GetDocument(Guid docId)
        {
            return _document.Find(docId);
        }

        public ServicesResult UpdateDocument(VmDocUpdate vmDocUpdate)
        {
            try
            {

                var orginalDoc = _document.Find(vmDocUpdate.DocId);
                if (orginalDoc == null)
                {
                    return new ServicesResult()
                    {
                        Success = false,
                        Message = "Document Not Found",
                        
                    };
                }


                var docHistory = new DocHistory()
                {
                    TypeId = (int)DocHistoryEnumerable.DocHistoryType.EditeDocument,
                    DocId = orginalDoc.DocId,
                    ChangeSet = orginalDoc.Subject + Environment.NewLine + orginalDoc.Content,
                    OwnerUserId = vmDocUpdate.OwnerUserId,
                    OwnerDepartmentId = _chartService.GetDepartment(vmDocUpdate.FolId).ChartId

                };



                orginalDoc.Content = vmDocUpdate.Content;
                orginalDoc.Subject = vmDocUpdate.Subject;

                _uow.MarkAsChanged(orginalDoc);
                _docHistory.Add(docHistory);



                _uow.SaveChanges();

                return new ServicesResult()
                {
                    Success = true,
                    Message = "OK",
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


        #region DocHistory
        public ICollection<DocHistory> GetDocumentHistory(Guid docId)
        {
           return _docHistory.Include(i=>i.OwnerDepartment).Include(i=>i.OwnerUser).Include(i=>i.Type).Where(w => w.DocId == docId).ToList();
        }

        #endregion DocHistory
    }
}
