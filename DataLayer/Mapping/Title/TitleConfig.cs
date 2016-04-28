using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Mapping.Title
{
    public class TitleConfig : EntityTypeConfiguration<DomainLayer.DB_Model.Title.Title>
    {

        public TitleConfig()
        {



            this.Map(m =>
            {
                //اگر کلاس ارث گرفته از کلاس والد باشد فیلدهای کلاس  والد را لحاظ میکنیم
                m.MapInheritedProperties();
                m.ToTable("tbl_title");
            });

            this.HasKey(key => key.Id);


            this.Property(p => p.Name).IsRequired().HasMaxLength(500);





            this.HasRequired(r => r.Type)
                .WithMany()
                .HasForeignKey(f => f.TypeId).WillCascadeOnDelete(false);


            this.HasRequired(r => r.ReceverDepartment)
                .WithMany()
                .HasForeignKey(f => f.ReceverDepartmentId).WillCascadeOnDelete(false);


            this.HasRequired(r => r.ReceverEmployee)
             .WithMany()
             .HasForeignKey(f => f.ReceverEmployeeId)
             .WillCascadeOnDelete(false);


            this.HasRequired(r => r.OwnerDepartment)
            .WithMany()
            .HasForeignKey(f => f.OwnerDepartmentId).WillCascadeOnDelete(false);


            this.HasRequired(r => r.OwnerEmployee)
                .WithMany()
                .HasForeignKey(f => f.OwnerEmployeeId).WillCascadeOnDelete(false);


        }


    }
}
