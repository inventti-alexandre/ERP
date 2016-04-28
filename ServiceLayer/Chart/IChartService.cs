using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DomainLayer.App_Model.General;
using DomainLayer.DB_Model.Chart;
using Type = DomainLayer.DB_Model.General.Type;

namespace ServiceLayer.Chart
{
    public interface IChartService
    {


        Task<ServicesResult> CreateAsync(DomainLayer.DB_Model.Chart.Chart chartModel);
        ServicesResult Create(DomainLayer.DB_Model.Chart.Chart chartModel);


        Task<ServicesResult> UpdateAsync(DomainLayer.DB_Model.Chart.Chart chartModel);
        ServicesResult Update(DomainLayer.DB_Model.Chart.Chart chartModel);
        
        
        
        Task<ServicesResult> DeleteAsync(Guid chartId);
        ServicesResult Delete(Guid chartId);


        List<DomainLayer.DB_Model.Chart.Chart> LoadChart();


        List<DomainLayer.DB_Model.Chart.Chart> FindWithParrentId(Guid? parentId);
        DomainLayer.DB_Model.Chart.Chart FindWithId(Guid chartId);


        Task<List<Type>> GetChartTypeList();

        DomainLayer.DB_Model.Chart.Chart GetDepartment(Guid folid);
        DomainLayer.DB_Model.Chart.Chart GetFolders(Guid departmentId, ChartEnumerable.FolderType type);


        string GetTreeJson();



    }
}