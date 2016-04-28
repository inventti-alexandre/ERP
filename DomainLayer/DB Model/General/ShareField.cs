using System;
using System.ComponentModel;

namespace DomainLayer.DB_Model.General
{
    public abstract class ShareField
    {
        protected ShareField()
        {
          
            RegisterDate = DateTime.Now;
            RegisterDateSh = FrameWork.General.Date.Getdate();
            IsActive = true;

        }

        public Guid OwnerUserId { get; set; }
      

        public byte[] RowVersion { get; set; }
        public DateTime RegisterDate { get; set; }

        [DisplayName("تاریخ درج")]
        public string RegisterDateSh { get; set; }

        [DisplayName("فعال")]
        public bool IsActive { get; set; }

    }
}
