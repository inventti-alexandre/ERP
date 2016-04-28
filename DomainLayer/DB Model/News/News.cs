using System;
using System.ComponentModel;
using System.Web.Mvc;
using DomainLayer.DB_Model.General;

namespace DomainLayer.DB_Model.News
{
    public class News:ShareField
    {



        public News()
        {
            NewsId = Guid.NewGuid();
        }


        #region Feild

        public Guid NewsId { get; set; }

        [DisplayName("عنوان خبر")]
        public string Subject { get; set; }

        [DisplayName("پیش گفتار")]
        [AllowHtml]
        public string Header { get; set; }

        [DisplayName("محتوا")]
        [AllowHtml]
        public string Body { get; set; }
        
        #endregion Feild

        #region Relation

        [DisplayName("گروه خبری")]
        public virtual NewsGroup NewsGroup { get; set; }
       
        
        [DisplayName("گروه خبری")]
        public Guid NewsGroupId { get; set; }



        #endregion Relation

    }
}
