using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Mapping.Employee
{
    public class EmployeeConfig : EntityTypeConfiguration<DomainLayer.DB_Model.Employee.Employee>
    {
        public EmployeeConfig()
        {
            this.ToTable("tbl_Employee");
          

            this.HasKey(key => key.AppUserId);
            this.Property(p => p.NationalId).IsRequired().HasMaxLength(10);


            this.Property(p => p.FirstName).IsRequired().HasMaxLength(50);
            this.Property(p => p.LastName).IsRequired().HasMaxLength(100);

            this.Ignore(i => i.FullName);
          


            this.Property(p => p.FatherName).IsOptional().HasMaxLength(50);


            this.Property(p => p.BirthDay).IsRequired().HasMaxLength(10);
            this.Property(p => p.Picture).IsOptional();

            this.Property(p => p.OwnerUserId).IsRequired();
            this.Property(p => p.RowVersion).IsRowVersion();
            this.Property(p => p.RegisterDate).HasColumnType("date").IsRequired();
            this.Property(p => p.RegisterDateSh).IsRequired().HasMaxLength(10);



           


        }
    }
}