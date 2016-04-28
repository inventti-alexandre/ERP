using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.DB_Model.General;
using Type = DomainLayer.DB_Model.General.Type;

namespace DomainLayer.DB_Model.Title
{
    public class Title:ShareField
    {


        public Title()
        {
            Id = Guid.NewGuid();
        }


        #region Feild

        public Guid Id { get; set; }
        public string Name { get; set; }


        //شناسه نوع
        public int TypeId { get; set; }


        //شناسه سند
        public Guid DocId { get; set; }

        //شناسه سمت دریافت کننده
        public Guid ReceverDepartmentId { get; set; }

        //شناسه شخص دریافت کننده سند
        public Guid ReceverEmployeeId { get; set; }

        //شناسه شخص فرستنده 
        public Guid OwnerEmployeeId { get; set; }

        //شناسه سمت فرستنده 
        public Guid OwnerDepartmentId { get; set; }

        #endregion Feild





        #region Relation

        public virtual Documents.Document Document { get; set; }

        public Type Type { get; set; }


        public virtual Chart.Chart ReceverDepartment { get; set; }
        public virtual Employee.Employee ReceverEmployee { get; set; }


        public virtual Chart.Chart OwnerDepartment { get; set; }
        public virtual Employee.Employee OwnerEmployee { get; set; }


        #endregion Relation

    }
}
