using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
using DomainLayer.App_Model.General;

namespace ServiceLayer.General.Type
{
    public class TypeService:ITypeService
    {

        private readonly IDbSet<DomainLayer.DB_Model.General.Type> _type;
        private readonly IUnitOfWork _uow;


        public TypeService(IUnitOfWork uow)
        {
            _uow = uow;
            _type = _uow.Set<DomainLayer.DB_Model.General.Type>();
        }


        public Task<List<DomainLayer.DB_Model.General.Type>> LoadWithGroupIdAsync(int groupId)
        {  
            return _type.Where(w => w.Group == groupId && w.Order!=0).OrderBy(o=>o.Order).ToListAsync();
        }

        public DomainLayer.DB_Model.General.Type LoadWithCode(int code)
        {
            return _type.Single(s => s.Code == code);
        }

        public DomainLayer.DB_Model.General.Type LoadWithId(int id)
        {
            return _type.Find(id);
        }

        public async Task<ServicesResult> CreateAsync(DomainLayer.DB_Model.General.Type type)
        {
            try
            {
                _type.Add(type);
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
    }
}
