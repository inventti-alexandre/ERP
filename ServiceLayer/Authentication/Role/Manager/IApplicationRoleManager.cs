using System;
using System.Linq;
using System.Threading.Tasks;
using DomainLayer.DB_Model.Authentication;
using Microsoft.AspNet.Identity;

namespace ServiceLayer.Authentication.Role.Manager
{
    public interface IApplicationRoleManager : IDisposable
    {
        /// <summary>
        ///     Used to validate roles before persisting changes
        /// </summary>
        IIdentityValidator<ApplicationRole> RoleValidator { get; set; }

        /// <summary>
        ///     Returns an IQueryable of roles if the store is an IQueryableRoleStore
        /// </summary>
        IQueryable<ApplicationRole> Roles { get; }

        /// <summary>
        ///     Create a role
        /// </summary>
        /// <param name="role" />
        /// <returns />
        Task<IdentityResult> CreateAsync(ApplicationRole role);

        /// <summary>
        ///     Update an existing role
        /// </summary>
        /// <param name="role" />
        /// <returns />
        Task<IdentityResult> UpdateAsync(ApplicationRole role);

        /// <summary>
        ///     Delete a role
        /// </summary>
        /// <param name="role" />
        /// <returns />
        Task<IdentityResult> DeleteAsync(ApplicationRole role);

        /// <summary>
        ///     Returns true if the role exists
        /// </summary>
        /// <param name="roleName" />
        /// <returns />
        Task<bool> RoleExistsAsync(string roleName);

        /// <summary>
        ///     Find a role by id
        /// </summary>
        /// <param name="roleId" />
        /// <returns />
        Task<ApplicationRole> FindByIdAsync(Guid roleId);

        /// <summary>
        ///     Find a role by name
        /// </summary>
        /// <param name="roleName" />
        /// <returns />
        Task<ApplicationRole> FindByNameAsync(string roleName);


        // Our new custom methods

        ApplicationRole FindRoleByName(string roleName);
        IdentityResult CreateRole(ApplicationRole role);

        void SeedDataBase();


    }
}