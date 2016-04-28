using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
using DomainLayer.App_Model.General;
using DomainLayer.DB_Model.News;

namespace ServiceLayer.News
{
    public class NewsGroupServices:INewsGroupServices
    {


        private readonly IDbSet<NewsGroup> _NewsGroup;

        private readonly IUnitOfWork _uow;

        public NewsGroupServices(IUnitOfWork uow)
        {
            _uow = uow;
            _NewsGroup = _uow.Set<NewsGroup>();
        }



        public async Task<ServicesResult> CreateNewGroupAsync(NewsGroup NewsGroup)
        {
            try
            {
                _NewsGroup.Add(NewsGroup);

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

        public IList<NewsGroup> GetGroupList()
        {
            return _NewsGroup.OrderByDescending(o=>o.RegisterDate).ToList();
        }
    }
}
