using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DomainLayer.DB_Model.Authentication
{
    public class ApplicationRole : IdentityRole<Guid, ApplicationUserRole>
    {
        #region Cunstructor


        public string  DisplayedName { get; set; }

        public ApplicationRole()
        {
            Id = Guid.NewGuid();
        }

        public ApplicationRole(string name,string displayName)
        {
            Name = name;
            Id = Guid.NewGuid();
            DisplayedName = displayName.Trim();

        }

        #endregion Cunstructor
    }
}