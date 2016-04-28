using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Mapping.EmployeeChart
{
    public class EmployeeChartConfig : EntityTypeConfiguration<DomainLayer.DB_Model.EmployeeChart.EmployeeChart>
    {

        public EmployeeChartConfig ()
        {

            this.ToTable("tbl_ChartEmployee");
            this.HasKey(e => new { e.ChartId, e.AppUserId });
           
        }


    }
}
