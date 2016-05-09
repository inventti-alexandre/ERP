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
                m.ToTable("tbl_Title");
            });

            this.HasKey(key => key.Id);


            this.Property(p => p.Name).IsRequired().HasMaxLength(500);





            this.HasRequired(r => r.Type)
                .WithMany()
                .HasForeignKey(f => f.TypeId).WillCascadeOnDelete(false);


            this.HasRequired(r => r.ReceiverDepartment)
                .WithMany()
                .HasForeignKey(f => f.ReceiverDepartmentId).WillCascadeOnDelete(false);


            this.HasRequired(r => r.ReceiverEmployee)
             .WithMany()
             .HasForeignKey(f => f.ReceiverEmployeeId)
             .WillCascadeOnDelete(false);



            this.HasRequired(r => r.OwnerEmployee)
                .WithMany()
                .HasForeignKey(f => f.OwnerUserId).WillCascadeOnDelete(false);


        }


    }
}
