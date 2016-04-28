using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DomainLayer.App_Model.DB_VM
{
    public class VmDocDraftSave
    {


        public string Subject { get; set; }

        [AllowHtml]
        public string Content { get; set; }

        public Guid DraftFolderId { get; set; }


        public Guid OwnerUserId { get; set; }


    }
}
