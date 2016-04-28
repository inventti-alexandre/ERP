using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.DB_Model.Authentication;

namespace DataLayer.Mapping.Authrnticate
{
    public static class AppUserLoginConfig
    {
        public static void SetConfig(DbModelBuilder modelBuilder)
        {
            var appUser = modelBuilder.Entity<ApplicationUserLogin>();

            appUser.ToTable("tbl_UserLogin");
        }
    }
}