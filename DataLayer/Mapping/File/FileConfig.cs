using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Mapping.File
{
    public class FileConfig : EntityTypeConfiguration<DomainLayer.DB_Model.File.File>
    {
        public FileConfig()
        {
            this.ToTable("tbl_Files");

            this.HasKey(key => key.Id);

            this.Property(p => p.FileName).HasMaxLength(50).IsRequired();
            this.Property(p => p.Description).HasMaxLength(500).IsOptional();


            this.Property(p => p.Content).IsRequired();
            this.Property(p => p.Lenght).IsRequired();
            this.Property(p => p.ContentType).IsRequired();
            this.Property(p => p.IsActive).IsRequired();


            this.Property(p => p.OwnerUserId).IsRequired();
            this.Property(p => p.RegisterDate).IsRequired().HasColumnType("date");
            this.Property(p => p.RegisterDateSH).IsRequired().HasMaxLength(10);
        }
    }
}