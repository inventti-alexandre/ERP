using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = DomainLayer.DB_Model.General.Type;

namespace DataLayer.Mapping.General
{
    public class TypeConfig : EntityTypeConfiguration<Type>
    {
        public TypeConfig()
        {
           

            //for TPC
            this.Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("tbl_Type");
            });


            this.HasKey(key => key.TypeId);


            this.Property(p => p.Code).IsRequired();
            this.Property(p => p.Group).IsRequired();


            this.Property(p => p.Subject).HasMaxLength(50).IsRequired();
            this.Property(p => p.Description).HasMaxLength(500).IsOptional();


        }

    }
}
