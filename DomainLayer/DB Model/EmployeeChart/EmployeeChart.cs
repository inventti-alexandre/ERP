using System;
using DomainLayer.DB_Model.General;

namespace DomainLayer.DB_Model.EmployeeChart
{
    public class EmployeeChart:ShareField
    {



        //public EmployeeChart()
        //{
        //    Id=Guid.NewGuid();
        //}


     


        public Guid AppUserId { get; set; }
        public Guid ChartId { get; set; }

        public virtual Chart.Chart Chart { get; set; }
        public virtual Employee.Employee Employee { get; set; }




    }
}
