using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.App_Model.DB_VM
{
    public class VmDocTitlePost
    {
        public string DocId { get; set; }

        public List<DocTitlePos> Titles { get; set; }

        public string Folid { get; set; }


        public string OwnerUserId { get; set; }


        public int TypeId { get; set; }


    }

    public class DocTitlePos
    {
        public string ReceiverFolIds { get; set; }
        public string ReceiverPrsId { get; set; }
    }
}
