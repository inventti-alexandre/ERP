using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Mapping.Chart
{
    public class ChartConfig : EntityTypeConfiguration<DomainLayer.DB_Model.Chart.Chart>
    {

        public ChartConfig()
        {




          
         

            //this.ToTable("tbl_Chart");
            //for TPC
            this.Map(m =>
            {
                //اگر کلاس ارث گرفته از کلاس والد باشد فیلدهای کلاس  والد را لحاظ میکنیم
                m.MapInheritedProperties();
                m.ToTable("tbl_Chart");
            });

            this.HasKey(key => key.ChartId);


            this.Property(p => p.Name).HasMaxLength(50);
          
            this.Property(p => p.IsActive).IsRequired();

            this.HasRequired(r => r.Type).
                WithMany().
                HasForeignKey(f=>f.TypeId).WillCascadeOnDelete(false);

            this.Property(p => p.ParentId).IsOptional();
            
            //this.HasMany(c => c.Children)
            //    .WithOptional(c => c.Parent)
            //    .HasForeignKey(c => c.ParentId)
            //    .WillCascadeOnDelete(false);

                        
             this.HasOptional(x => x.Parent)
                  .WithMany(x => x.Children)
                  .HasForeignKey(x => x.ParentId)
                  .WillCascadeOnDelete(false);

            

            


        }

    }
}
