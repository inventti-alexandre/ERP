using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.App_Model.General;

namespace ServiceLayer.News
{
    public interface INewsServices
    {

        
        IList<DomainLayer.DB_Model.News.News> GetNewsList(NewsServices.ListMode listMode=NewsServices.ListMode.All);

        DomainLayer.DB_Model.News.News Find(Guid id);
        
        
        
        Task<ServicesResult> CreateNewsAsync(DomainLayer.DB_Model.News.News News);

        Task<ServicesResult> DeActiveAsync(Guid newsId);

        Task<ServicesResult> DeleteAsync(Guid newsId);

        Task<ServicesResult> UpdateAsync(DomainLayer.DB_Model.News.News News);


    }
}
