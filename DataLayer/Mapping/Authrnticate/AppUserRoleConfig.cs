using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.DB_Model.Authentication;

namespace DataLayer.Mapping.Authrnticate
{
    public static class AppUserRoleConfig
    {
        public static void SetConfig(DbModelBuilder modelBuilder)
        {
            var appUser = modelBuilder.Entity<ApplicationUserRole>();

            appUser.ToTable("tbl_UserRole");
        }
    }
}