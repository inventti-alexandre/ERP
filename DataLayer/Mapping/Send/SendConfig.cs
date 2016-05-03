using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Mapping.Send
{
    public class SendConfig : EntityTypeConfiguration<DomainLayer.DB_Model.Send.Send>
    {

        public SendConfig()
        {
            //this.ToTable("tbl_send");
            this.Map(m =>
            {
                //اگر کلاس ارث گرفته از کلاس والد باشد فیلدهای کلاس  والد را لحاظ میکنیم
                m.MapInheritedProperties();
                m.ToTable("tbl_Send");
            });

            this.HasKey(key => key.SendId);
            this.Property(p => p.SendDescription).HasMaxLength(500);



            this.HasRequired(r => r.Folder).
               WithMany().
               HasForeignKey(f => f.FolderId).WillCascadeOnDelete(false);


            this.HasRequired(r => r.ReceverDepartment).
               WithMany().
               HasForeignKey(f => f.ReceverDepartmentId).WillCascadeOnDelete(false);


            this.HasRequired(r => r.ReceverEmployee).
             WithMany().
             HasForeignKey(f => f.ReceverEmployeeId).WillCascadeOnDelete(false);


            this.HasRequired(r => r.SenderDepartment).
           WithMany().
           HasForeignKey(f => f.SenderDepartmentId).WillCascadeOnDelete(false);


            this.HasRequired(r => r.SenderEmployee).
            WithMany().
            HasForeignKey(f => f.SenderEmployeeId).WillCascadeOnDelete(false);


        }

    }
}
