using System;
using System.ComponentModel;
using DomainLayer.DB_Model.General;

namespace DomainLayer.DB_Model.News
{
    public class NewsGroup:ShareField
    {


        public NewsGroup()
        {
            NewsGroupId = Guid.NewGuid();
        }

        
        public Guid NewsGroupId { get; set; }
        
        [DisplayName("نام گروه")]
        public string Name{ get; set; }

        [DisplayName("توضیحات")]
        public string Description { get; set; }

    }
}
