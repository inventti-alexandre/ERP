using System;
using System.Data.Entity;
using System.Threading.Tasks;
using DataLayer.Context;

namespace ServiceLayer.File
{
    public class FileServise : IFileService
    {
        private readonly IDbSet<DomainLayer.DB_Model.File.File> _file;
        private readonly IUnitOfWork _uow;


        public FileServise(IUnitOfWork uow)
        {
            _uow = uow;
            _file = _uow.Set<DomainLayer.DB_Model.File.File>();
        }


        public async Task<bool> Upload(DomainLayer.DB_Model.File.File fileModel)
        {
            try
            {
                _file.Add(fileModel);
                await _uow.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Task<DomainLayer.DB_Model.File.File> Download(Guid fileId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid fileId)
        {
            try
            {
                var file = _file.Find(fileId);
                if (file == null) return false;

                file.IsActive = false;

                _uow.MarkAsChanged(file);
                await _uow.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}