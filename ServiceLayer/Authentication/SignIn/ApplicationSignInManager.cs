using System;
using DomainLayer.DB_Model.Authentication;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using ServiceLayer.Authentication.User.Manager;
using ServiceLayer.Properties;

namespace ServiceLayer.Authentication.SignIn
{
    [UsedImplicitly]
    public class ApplicationSignInManager : SignInManager<ApplicationUser, Guid>, IApplicationSignInManager
    {
        #region Cunstructor

        private readonly IAuthenticationManager _authenticationManager;
        private readonly ApplicationUserManager _userManager;

        public ApplicationSignInManager(ApplicationUserManager userManager, IAuthenticationManager authenticationManager)
            :
                base(userManager, authenticationManager)
        {
            _userManager = userManager;
            _authenticationManager = authenticationManager;
        }

        #endregion Cunstructor

        public override Guid ConvertIdFromString(string id)
        {
            if (string.IsNullOrEmpty(id)) return Guid.Empty;

            return new Guid(id);
        }


        public override string ConvertIdToString(Guid id)
        {
            if (id.Equals(Guid.Empty)) return string.Empty;

            return id.ToString();
        }
    }
}