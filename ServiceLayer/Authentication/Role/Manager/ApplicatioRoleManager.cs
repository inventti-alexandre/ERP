using System;
using DomainLayer.DB_Model.Authentication;
using Microsoft.AspNet.Identity;
using ServiceLayer.Properties;

namespace ServiceLayer.Authentication.Role.Manager
{
    [UsedImplicitly]
    public class ApplicatioRoleManager : RoleManager<ApplicationRole, Guid>, IApplicationRoleManager
    {
        #region Cunstructor

        private readonly IRoleStore<ApplicationRole, Guid> _roleStore;

        public ApplicatioRoleManager(IRoleStore<ApplicationRole, Guid> store) : base(store)
        {
            _roleStore = store;
        }

        #endregion Cunstructor

        //[CacheMethodAttribute]
        public ApplicationRole FindRoleByName(string roleName)
        {
            return this.FindByName(roleName);
        }

        public IdentityResult CreateRole(ApplicationRole role)
        {
            return this.Create(role);
        }

        public void SeedDataBase()
        {
            //main admin Create with user in class ApplicationUserManager
            //this.Create(new ApplicationRole("MainAdmin"));


            if (this.FindRoleByName("MainAdmin") == null)
            {
                this.Create(new ApplicationRole("MainAdmin","دسترسی به تمام بخش ها"));
            }


            if (this.FindRoleByName("AppAdmin") == null)
            {
                this.Create(new ApplicationRole("AppAdmin","زیر سیستم مدیریت"));
            }

            if (this.FindRoleByName("AppNews") == null)
            {
                this.Create(new ApplicationRole("AppNews","زیر سیستم اخبار"));
            }

            if (this.FindRoleByName("AppWorkFlow") == null)
            {
                this.Create(new ApplicationRole("AppWorkFlow", "زیر سیستم گردش اطلاعات"));
            }

            if (this.FindRoleByName("AppShop") == null)
            {
                this.Create(new ApplicationRole("AppShop", "زیر سیستم فروش"));
            }


        

        }
    }
}