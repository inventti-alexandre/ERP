using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Profile;
using DomainLayer.DB_Model.Documents;
using DomainLayer.DB_Model.EmployeeChart;
using DomainLayer.DB_Model.Send;

namespace DomainLayer.App_Model.DB_VM
{
    public class VmDocSend
    {

        public VmDocSend()
        {
            Documents=new List<Document>();
            SendDescription = "";
            Receiver=new List<EmployeeChart>();
            AvalableReceiver=new List<EmployeeChart>();
        }

        public ICollection<Document> Documents { get; set; }

        public string SendDescription { get; set; }


        public ICollection<EmployeeChart> Receiver { get; set; }


        public EmployeeChart Sender { get; set; }


        public ICollection<EmployeeChart>  AvalableReceiver { get; set; }


    }
}
