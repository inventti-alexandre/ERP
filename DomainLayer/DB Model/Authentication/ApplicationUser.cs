using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DomainLayer.DB_Model.Authentication
{
    public sealed class ApplicationUser : IdentityUser<Guid, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid();
            IsActive = false;
        }


        public Employee.Employee Employee { get; set; }


        public bool IsActive { get; set; }
    }
}