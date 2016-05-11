using System;
using System.Collections.Generic;
using DomainLayer.App_Model.General;
using DomainLayer.DB_Model.Title;

namespace ServiceLayer.WorkFlow.DocTitle
{
    public interface IDocTitleService
    {
        ICollection<DomainLayer.DB_Model.EmployeeChart.EmployeeChart> GetAvalableTitle();

        DomainLayer.DB_Model.Documents.Document GetDocument(Guid docId);


        ICollection<DomainLayer.DB_Model.Title.Title> GetDocTitles(Guid docid);


        ServicesResult AddDocTitle(IList<Title> titles);

        ServicesResult RemoveDocTitle(IList<string> titleId, Guid ownerUserId, Guid ownerFolId);

        int MaxTitleOrder(Guid docId);


    }
}