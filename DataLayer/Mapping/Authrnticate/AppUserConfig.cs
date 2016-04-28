using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.DB_Model.Authentication;

namespace DataLayer.Mapping.Authrnticate
{
    public static class AppUserConfig
    {
        public static void SetConfig(DbModelBuilder modelBuilder)
        {
            var appUser = modelBuilder.Entity<ApplicationUser>();

            appUser.ToTable("tbl_User");

            appUser.HasOptional(o => o.Employee).WithRequired(r => r.AppUser).WillCascadeOnDelete(true);
        }
    }
}