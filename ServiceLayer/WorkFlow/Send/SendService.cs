using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Context;
using DomainLayer.App_Model.General;
using DomainLayer.DB_Model.Chart;
using ServiceLayer.Chart;

namespace ServiceLayer.WorkFlow.Send
{
    public class SendService: ISendService
    {
        private readonly IUnitOfWork _uow;
        private readonly IDbSet<DomainLayer.DB_Model.Send.Send> _send;
        private readonly IChartService _chartService;

        public SendService(IUnitOfWork uow, IChartService chartService)
        {
            _uow = uow;
            _chartService = chartService;
            _send = _uow.Set<DomainLayer.DB_Model.Send.Send>();
            
        }


        
        #region Create
        public async Task<ServicesResult> CreateNewSendAsync(DomainLayer.DB_Model.Send.Send send)
        {
            try
            {

                _send.Add(send);

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

        public ServicesResult CreateNewSend(DomainLayer.DB_Model.Send.Send send)
        {
            try
            {

                _send.Add(send);

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

        #endregion Create

        #region Draft Folder
        public IList<DomainLayer.DB_Model.Send.Send> LoadDraftFolder(Guid folderid)
        {
            return _send.Where(w => w.FolderId == folderid).ToList();
        }



        #endregion Draft Folder

        #region recycle Folder

        public IList<DomainLayer.DB_Model.Send.Send> LoadRecyclFolder(Guid folderid)
        {
            return _send.Where(w => w.FolderId == folderid).ToList();
        }

        public ServicesResult MoveToRecyle(List<string> senids)
        {
            try
            {
                foreach (string senId in senids)
                {
                    var senRecord = _send.Find(Guid.Parse(senId));
                    senRecord.FolderId = _chartService.GetFolders(senRecord.ReceverDepartmentId,ChartEnumerable.FolderType.Recycle).ChartId;

                    _uow.MarkAsChanged(senRecord);
                    _uow.SaveChanges();
                }

                return new ServicesResult()
                {
                    Success = true,
                    ErrorCount = 0,
                    Message = "ok",
                    Data = senids.Count,
                };

            }
            catch (Exception ex)
            {

                return new ServicesResult()
                {
                    Success = false,
                    ErrorCount = ex.HResult,
                    Message = ex.Message,
                    InnerExeption = ex.InnerException.Message,
                    
                };
            }

        }



        #endregion recycle Folder

        #region Flow
        public ICollection<DomainLayer.DB_Model.Send.Send> ShowDocumentSends(Guid docId)
        {
            return _send.Where(w => w.DocId == docId).OrderBy(o => o.RegisterDate).ToList();
        }

        #endregion

    }
}
