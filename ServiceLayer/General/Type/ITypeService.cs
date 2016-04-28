using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.App_Model.General;

namespace ServiceLayer.General.Type
{
    public interface ITypeService
    {

        Task<List<DomainLayer.DB_Model.General.Type>> LoadWithGroupIdAsync(int groupId);
        DomainLayer.DB_Model.General.Type LoadWithCode(int code);
        DomainLayer.DB_Model.General.Type LoadWithId(int id);


        Task<ServicesResult> CreateAsync(DomainLayer.DB_Model.General.Type type);



    }
}
