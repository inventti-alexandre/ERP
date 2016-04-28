using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.DB_Model.News;

namespace DataLayer.Mapping.News
{
    public class NewsGroupConfig : EntityTypeConfiguration<NewsGroup>
    {

        public NewsGroupConfig()
        {


            this.Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("tbl_NewsGroup");
            });
            
            
            this.HasKey(key => key.NewsGroupId);


        }

    }
}
