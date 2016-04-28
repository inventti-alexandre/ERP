using System;
using System.Collections.Generic;
using System.ComponentModel;
using DomainLayer.DB_Model.General;
using Type = DomainLayer.DB_Model.General.Type;

namespace DomainLayer.DB_Model.Chart
{
    public class Chart:ShareField
    {


        #region Relation
        
        
        //ارتباط درختی
        public virtual ICollection<Chart> Children { get; set; }
        public Chart Parent { get; set; }
        public Guid? ParentId { get; set; }

       
        
        //نوع را مشخص میکند مثل سازمان یا واحد بودن

         [DisplayName("نوع جایگاه")]
        public virtual Type Type { get; set; }
        public int TypeId { get; set; }



        //ارتباط با کارمندان
        public virtual ICollection<EmployeeChart.EmployeeChart> Employee { get; set; }



        #endregion Relation



        public Guid ChartId { get; set; }

        [DisplayName("نام جایگاه")]
        public string Name { get; set; }

        [DisplayName("اولویت")]
        public int Priority { get; set; }




    }



}