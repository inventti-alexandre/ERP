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
            IsSended = false;
        }


        #region Feild

        public Guid Id { get; set; }

        //توضیح هنگام ارسال
        public string SenDescription { get; set; }


        //شناسه نوع
        public int TypeId { get; set; }


        //شناسه سند
        public Guid DocId { get; set; }

        //اولویت
        public int Order { get; set; }

        //شناسه سمت دریافت کننده
        public Guid ReceiverDepartmentId { get; set; }

        //شناسه شخص دریافت کننده سند
        public Guid ReceiverEmployeeId { get; set; }

        //آیا به عنوان ارسال شده یا خیر
        public bool IsSended { get; set; }

        #endregion Feild





        #region Relation

        public virtual Documents.Document Document { get; set; }

        public virtual Type Type { get; set; }


        public virtual Chart.Chart ReceiverDepartment { get; set; }
        public virtual Employee.Employee ReceiverEmployee { get; set; }

        

        public virtual Employee.Employee OwnerEmployee { get; set; }


        #endregion Relation

    }
}
