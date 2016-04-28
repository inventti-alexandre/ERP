using System.Data.Entity;
using DomainLayer.DB_Model.Authentication;

namespace DataLayer.Mapping.Authrnticate
{
    public static class AppRoleConfig
    {
        public static void SetConfig(DbModelBuilder modelBuilder)
        {
            var appUser = modelBuilder.Entity<ApplicationRole>();

            appUser.ToTable("tbl_Role");
        }
    }
}