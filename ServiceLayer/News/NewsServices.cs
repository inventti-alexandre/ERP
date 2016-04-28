using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
using DomainLayer.App_Model.General;

namespace ServiceLayer.News
{
    public class NewsServices : INewsServices
    {

        private readonly IDbSet<DomainLayer.DB_Model.News.News> _News;

        private readonly IUnitOfWork _uow;
        public NewsServices(IUnitOfWork uow)
        {
            _uow = uow;
            _News = _uow.Set<DomainLayer.DB_Model.News.News>();
        }


        public enum ListMode
        {
            All = 0,
            ActiveNews = 1,
            DeActiveNews = 2,
        }




        public IList<DomainLayer.DB_Model.News.News> GetNewsList(ListMode listMode=ListMode.All)
        {


            IQueryable<DomainLayer.DB_Model.News.News> query = _News.OrderByDescending(d => d.RegisterDate);


            switch (listMode)
            {

                case ListMode.ActiveNews:
                    query = query.Where(w => w.IsActive);
                    break;
                case ListMode.DeActiveNews:
                    query = query.Where(w =>!w.IsActive);
                    break;

            }

            return query.ToList();
        }

        public DomainLayer.DB_Model.News.News Find(Guid id)
        {
            return _News.Find(id);
        }

        public async Task<ServicesResult> CreateNewsAsync(DomainLayer.DB_Model.News.News News)
        {
            try
            {
                _News.Add(News);

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

        public async Task<ServicesResult> DeActiveAsync(Guid newsId)
        {
            try
            {

                var news = _News.Find(newsId);
                news.IsActive = false;
                _uow.MarkAsChanged(news);
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

        public async Task<ServicesResult> DeleteAsync(Guid newsId)
        {
            try
            {

                var news = _News.Find(newsId);
                _News.Remove(news);
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

        public async Task<ServicesResult> UpdateAsync(DomainLayer.DB_Model.News.News News)
        {
            try
            {

                _uow.MarkAsChanged(News);
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
