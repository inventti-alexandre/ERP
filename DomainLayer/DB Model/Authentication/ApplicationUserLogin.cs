using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DomainLayer.DB_Model.Authentication
{
    public class ApplicationUserLogin : IdentityUserLogin<Guid>
    {
        public ApplicationUserLogin()
        {
        }
    }
}