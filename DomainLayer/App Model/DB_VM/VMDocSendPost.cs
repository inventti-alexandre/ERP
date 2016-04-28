using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.App_Model.DB_VM
{
    public class VmDocSendPost
    {

        public List<string> DocIds { get; set; }
     
        public List<DocSendPostReciver> Recivers { get; set; }

        public string Folid{ get; set; }

        public string Description { get; set; }

        public string OwnerUserId { get; set; }

    }

    public class DocSendPostReciver
    {
        public string ReceiverFolIds { get; set; }
        public string ReceiverPrsId { get; set; }
    }

}
