using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Mvc;
using DomainLayer.DB_Model.General;

namespace DomainLayer.DB_Model.Documents
{
    public class Document: ShareField
    {


        public Document()
        {
            DocId = Guid.NewGuid();
            IsActive = true;
        }

        #region Feild
        public Guid DocId { get; set; }


        [DisplayName("شماره سند")]
        public long DocNo { get; set; }

        [DisplayName("موضوع سند")]
        public string Subject { get; set; }


        [AllowHtml]
        [DisplayName("محتوای سند")]
        public string Content { get; set; }

        #endregion

        #region Relation
        public ICollection<Title.Title> Titles { get; set; }

        public ICollection<Send.Send > Sends { get; set; }

        #endregion Relation





    }
}
