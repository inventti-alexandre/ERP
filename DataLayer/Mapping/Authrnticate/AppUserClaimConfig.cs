using System.Data.Entity;
using DomainLayer.DB_Model.Authentication;

namespace DataLayer.Mapping.Authrnticate
{
    public static class AppUserClaimConfig
    {
        public static void SetConfig(DbModelBuilder modelBuilder)
        {
            var appUser = modelBuilder.Entity<ApplicationUserClaim>();

            appUser.ToTable("tbl_UserClaim");
        }
    }
}