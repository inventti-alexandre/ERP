using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AOP.Cache;
using DataLayer.Context;
using DomainLayer.App_Model.General;

namespace ServiceLayer.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IDbSet<DomainLayer.DB_Model.Employee.Employee> _employee;
     
        private readonly IUnitOfWork _uow;


        public EmployeeService(IUnitOfWork uow)
        {
            _uow = uow;
            _employee = _uow.Set<DomainLayer.DB_Model.Employee.Employee>();
           
        }

       

        public async Task<ServicesResult> CreateAsync(DomainLayer.DB_Model.Employee.Employee employee)
        {
            try
            {

                //کد ملی تکراری مورد قبول نیست
                var existEmployee = DuplicateNationalId(employee.NationalId);
                if (existEmployee)
                {
                    return new ServicesResult()
                    {

                        Success = false,
                        Message = "کد ملی تکراری است"
                    
                    };
                }


                _employee.Add(employee);

                await _uow.SaveChangesAsync();
                return new ServicesResult()
                {
                    Success = true
                };
            }
            catch (Exception ex)
            {
                return new ServicesResult()
                {
                    Success = false,
                    
                    Message = ex.Message,
                    InnerExeption = ex.InnerException.Message,

                };
            }
        }

        public async Task<ServicesResult> UpdateAsync(DomainLayer.DB_Model.Employee.Employee employee)
        {
            try
            {

               
                _uow.MarkAsChanged(employee);
                await _uow.SaveChangesAsync();
                return new ServicesResult()
                {
                    Success = true
                };
            }
            catch (Exception ex)
            {
                return new ServicesResult()
                {
                    Success = false,
                   
                    Message = ex.Message,
                    InnerExeption = ex.InnerException.Message,

                };
            }
        }

        [CacheMethod(SecondsToCache = 60)]
        public IList<DomainLayer.DB_Model.Employee.Employee> GetAllEmployees()
        {
            return _employee.ToList();
        }


        public DomainLayer.DB_Model.Employee.Employee Find(Guid id)
        {
            return _employee.Find(id);
        }

        public bool DuplicateNationalId(string id)
        {
                return _employee.Any(s => s.NationalId == id.Trim());
        }

        public Task<bool> IsCompletMainInfo(Guid id)
        {
            return _employee.AnyAsync(s => s.AppUserId == id);
        }

        public byte[] GetImage(Guid id)
        {



            var x= _employee.Where(w => w.AppUserId == id).Select(s => s.Picture).ToArray();

            return x[0];


        }
    }
}