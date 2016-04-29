using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DomainLayer.App_Model.General;

namespace ServiceLayer.WorkFlow.Send
{
    public interface ISendService
    {

        Task<ServicesResult> CreateNewSendAsync(DomainLayer.DB_Model.Send.Send send);
        ServicesResult CreateNewSend(DomainLayer.DB_Model.Send.Send send);

        IList<DomainLayer.DB_Model.Send.Send> LoadDraftFolder(Guid folderid);
        



        IList<DomainLayer.DB_Model.Send.Send> LoadRecyclFolder(Guid folderid);

        ServicesResult MoveToRecyle(List<String> senids);


        ICollection<DomainLayer.DB_Model.Send.Send> ShowDocumentSends(Guid docId);







    }
}