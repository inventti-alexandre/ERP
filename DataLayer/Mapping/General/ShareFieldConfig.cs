using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.DB_Model.General;

namespace DataLayer.Mapping.General
{
    public abstract class ShareFieldConfig:EntityTypeConfiguration<ShareField>
    {

        public ShareFieldConfig()
        {

            // for TPC
            //this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            

            this.Property(p => p.OwnerUserId).IsRequired();
           
            this.Property(p => p.RowVersion).IsRowVersion();
            this.Property(p => p.RegisterDate).HasColumnType("date").IsRequired();
            this.Property(p => p.RegisterDateSh).IsRequired().HasMaxLength(10);
        }

    }
}
