using System;
using DomainLayer.DB_Model.Authentication;
using Microsoft.AspNet.Identity;
using ServiceLayer.Properties;

namespace ServiceLayer.Authentication.Role.Store
{
    [UsedImplicitly]
    public class ApplicationRoleStore : IApplicationRoleStore
    {
        private readonly IRoleStore<ApplicationRole, Guid> _roleStore;


        public ApplicationRoleStore(IRoleStore<ApplicationRole, Guid> roleStore)
        {
            _roleStore = roleStore;
        }
    }
}