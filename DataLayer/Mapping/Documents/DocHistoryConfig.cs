using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.DB_Model.Documents;

namespace DataLayer.Mapping.Documents
{
    public class DocHistoryConfig: EntityTypeConfiguration<DocHistory>
    {


        public DocHistoryConfig()
        {

            this.ToTable("tbl_DocumentsHistory");

            this.HasKey(key => key.Id);


            this.HasRequired(r => r.Type).
              WithMany().
              HasForeignKey(f => f.TypeId).WillCascadeOnDelete(false);


            this.HasRequired(r => r.OwnerUser).
            WithMany().
            HasForeignKey(f => f.OwnerUserId).WillCascadeOnDelete(false);


            this.HasRequired(r => r.OwnerDepartment).
           WithMany().
           HasForeignKey(f => f.OwnerDepartmentId).WillCascadeOnDelete(false);


            this.HasRequired(r => r.Document).
         WithMany().
         HasForeignKey(f => f.DocId).WillCascadeOnDelete(false);


        }

    }
}
