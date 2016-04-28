using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DomainLayer.App_Model.DB_VM
{
    public class VmDocUpdate
    {

        public Guid DocId { get; set; }


        [DisplayName("شماره سند")]
        public long DocNo { get; set; }

        [DisplayName("موضوع سند")]
        public string Subject { get; set; }


        [AllowHtml]
        [DisplayName("محتوای سند")]
        public string Content { get; set; }


        public Guid OwnerUserId { get; set; }

        public Guid FolId { get; set; }


        [DisplayName("تاریخ سند")]
        public string RegisterDateSh { get; set; }
        



    }
}
