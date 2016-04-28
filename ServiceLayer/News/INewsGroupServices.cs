using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.App_Model.General;
using DomainLayer.DB_Model.News;

namespace ServiceLayer.News
{
    public interface INewsGroupServices
    {

        Task<ServicesResult> CreateNewGroupAsync(NewsGroup NewsGroup);

        IList<NewsGroup> GetGroupList();

    }
}
