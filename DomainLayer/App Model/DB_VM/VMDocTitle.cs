using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.DB_Model.Documents;
using DomainLayer.DB_Model.EmployeeChart;

namespace DomainLayer.App_Model.DB_VM
{
    public class VmDocTitle
    {

        public VmDocTitle()
        {
            AvalableTitle = new List<EmployeeChart>();
        }


        public Document Document { get; set; }
        public ICollection<EmployeeChart> AvalableTitle { get; set; }
        public ICollection<DB_Model.Title.Title> SelectedTitle { get; set; }


    }
}
