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


        }

    }
}
