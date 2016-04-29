using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using DataLayer.Context;
using DomainLayer.App_Model.DB_VM;
using DomainLayer.App_Model.General;
using DomainLayer.DB_Model.Chart;
using DomainLayer.DB_Model.EmployeeChart;
using ServiceLayer.Chart;
using ServiceLayer.ChartEmployee;
using ServiceLayer.WorkFlow.Document;
using ServiceLayer.WorkFlow.Send;

namespace ServiceLayer.WorkFlow.DocSend
{
    public class DocSendService:IDocSendService
    {



        private readonly IDocumentService _documentService;
        private readonly ISendService _sendService;
        private readonly IChartEmployeeService _chartEmployeeService;
        private readonly IChartService _chartService;

        public DocSendService(IDocumentService documentService, IChartEmployeeService chartEmployeeService, ISendService sendService, IChartService chartService)
        {
            _documentService = documentService;
            _chartEmployeeService = chartEmployeeService;
            _sendService = sendService;
            _chartService = chartService;
        }


        public ICollection<DomainLayer.DB_Model.Documents.Document> GetReadyDocumentsForSend(IList<string> docIds)
        {
            return docIds.Select(docid => _documentService.GetDocument(Guid.Parse(docid))).ToList();
        }

        public ICollection<EmployeeChart> GetAvalablEmployeeForSend()
        {
            return _chartEmployeeService.ShowAll();
        }



        public  ServicesResult SendDocuments(VmDocSendPost docSendmodel)
        {
            try
            {

                foreach (var doc in docSendmodel.DocIds)
                {
                    foreach (var recivers in docSendmodel.Recivers)
                    {


                        var newsSendRecord=new DomainLayer.DB_Model.Send.Send()
                        {
                            DocId = Guid.Parse(doc),
                            OwnerUserId = Guid.Parse(docSendmodel.OwnerUserId),
                            SendDescription = docSendmodel.Description,
                            ReceverEmployeeId = Guid.Parse(recivers.ReceiverPrsId),
                            ReceverDepartmentId = Guid.Parse(recivers.ReceiverFolIds),
                            SenderEmployeeId = Guid.Parse(docSendmodel.OwnerUserId),
                           
                        };

                        newsSendRecord.FolderId =
                            _chartService.GetFolders(Guid.Parse(recivers.ReceiverFolIds),
                                ChartEnumerable.FolderType.Inbox).ChartId;

                        newsSendRecord.SenderDepartmentId =
                            _chartService.GetDepartment(Guid.Parse(docSendmodel.Folid)).ChartId;


                         _sendService.CreateNewSend(newsSendRecord);

                    }

                }


                return new ServicesResult()
                {
                    Success = true,
                    Message = "اسناد با موفقیت ارسال شد",
                    
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

        public ICollection<DomainLayer.DB_Model.Send.Send> GetDocSends(Guid docid)
        {
            return _sendService.ShowDocumentSends(docid);
        }
    }
}
