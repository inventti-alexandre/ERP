using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.DB_Model.General;
using Type = DomainLayer.DB_Model.General.Type;

namespace DomainLayer.DB_Model.Documents
{
    public class DocHistory:ShareField
    {


        public DocHistory()
        {
            Id=Guid.NewGuid();
        }


        #region Feild

        public Guid  Id { get; set; }

        public Guid DocId { get; set; }

        public int TypeId { get; set; }

        public string ChangeSet { get; set; }


        //شناسه سمت تغییر دهنده
        public Guid OwnerDepartmentId { get; set; }

       


        #endregion Feild

        #region Relation

        public Type Type { get; set; }

        public Document Document { get; set; }
        public virtual Chart.Chart OwnerDepartment { get; set; }
        public virtual Employee.Employee OwnerUser { get; set; }


        #endregion Relation



    }
}
