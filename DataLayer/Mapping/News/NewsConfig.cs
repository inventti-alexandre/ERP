using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Mapping.News
{
    public class NewsConfig : EntityTypeConfiguration<DomainLayer.DB_Model.News.News>
    {

        public NewsConfig()
        {
          
            
            this.Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("tbl_News");
            });
          

            this.HasKey(key => key.NewsId);
            this.Property(p => p.IsActive).IsRequired();


            this.HasRequired(r => r.NewsGroup).
               WithMany().
               HasForeignKey(f => f.NewsGroupId).WillCascadeOnDelete(true);

        }
      


    }
}
