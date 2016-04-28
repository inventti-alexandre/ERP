using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DomainLayer.App_Model.General;

namespace ServiceLayer.Employee
{
    public interface IEmployeeService
    {
        Task<ServicesResult> CreateAsync(DomainLayer.DB_Model.Employee.Employee employee);

        Task<ServicesResult> UpdateAsync(DomainLayer.DB_Model.Employee.Employee employee);

        IList<DomainLayer.DB_Model.Employee.Employee> GetAllEmployees();

        DomainLayer.DB_Model.Employee.Employee Find(Guid id);
        bool DuplicateNationalId(string id);

        Task<bool> IsCompletMainInfo(Guid id);

        byte[] GetImage(Guid id);


       


    }
}