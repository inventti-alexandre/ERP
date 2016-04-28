using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public interface IUnitOfWork
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();

        void MarkAsChanged<TEntity>(TEntity entity) where TEntity : class;

        IList<T> GetRows<T>(string sql, params object[] parameters) where T : class;
        void ForceDatabaseInitialize();


        Task<int> SaveChangesAsync();
    }
}