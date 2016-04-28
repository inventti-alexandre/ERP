using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.DB_Model.Documents;

namespace DataLayer.Mapping.Documents
{
    public class DocumentsConfig: EntityTypeConfiguration<Document>
    {

        public DocumentsConfig() {

            this.ToTable("tbl_Documents");
            this.HasKey(key => key.DocId);

            this.Property(p => p.DocNo).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Subject).HasMaxLength(500);




        }

    }
}
