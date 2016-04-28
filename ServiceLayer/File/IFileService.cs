using System;
using System.Threading.Tasks;

namespace ServiceLayer.File
{
    public interface IFileService
    {
        Task<bool> Upload(DomainLayer.DB_Model.File.File fileModel);

        Task<DomainLayer.DB_Model.File.File> Download(Guid fileId);


        Task<bool> Delete(Guid fileId);
    }
}