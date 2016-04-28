using System;
using DomainLayer.DB_Model.General;

namespace DomainLayer.DB_Model.Send
{


    public class Send :ShareField
    {

        public Send()
        {
            SendId = Guid.NewGuid();
        }



        #region Feild

        //شناسه ارسال
        public Guid SendId { get; set; }
        
        //شناسه سند
        public Guid DocId { get; set; }

        //شناسه پوشه ای که سند در آن قرار گرفته است
        public Guid FolderId { get; set; }
        
        //شناسه سمت دریافت کننده
        public Guid ReceverDepartmentId { get; set; }
        
        //شناسه شخص دریافت کننده سند
        public Guid ReceverEmployeeId { get; set; }

        //شناسه شخص فرستنده سند
        public Guid SenderEmployeeId { get; set; }
        
        //شناسه سمت فرستنده سند
        public Guid SenderDepartmentId { get; set; }



        //توضیح ارسال سند
        public string SendDescription { get; set; }

        #endregion



        #region Relation

        public virtual Documents.Document Document { get; set; }
        public virtual Chart.Chart Folder { get; set; }

        public virtual Chart.Chart ReceverDepartment { get; set; }
        public virtual Employee.Employee ReceverEmployee { get; set; }


        public virtual Chart.Chart SenderDepartment { get; set; }
        public virtual Employee.Employee SenderEmployee { get; set; }


        #endregion Relation





    }
}
