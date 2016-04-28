using System;
using DomainLayer.DB_Model.Authentication;
using Microsoft.AspNet.Identity;
using ServiceLayer.Properties;

namespace ServiceLayer.Authentication.User.Store
{
    [UsedImplicitly]
    public class ApplicationUserStore : IApplicationUserStore
    {
        private readonly IUserStore<ApplicationUser, Guid> _userStore;


        public ApplicationUserStore(IUserStore<ApplicationUser, Guid> userStore)
        {
            _userStore = userStore;
        }
    }
}