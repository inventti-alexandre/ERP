using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using DomainLayer.App_Model.General;
using DomainLayer.DB_Model.EmployeeChart;

namespace ServiceLayer.ChartEmployee
{
    public interface IChartEmployeeService
    {
        Task<ServicesResult> JoinPrsToChart(Guid prsId, Guid chartId);

        Task<ServicesResult> DisablePrsFromChart(Guid prsId, Guid chartId);
        Task<ServicesResult> EnablePrsFromChart(Guid prsId, Guid chartId);


        List<EmployeeChart> ShowEmployeeCharts(Guid prsId);
       List<EmployeeChart> ShowChartEmployees(Guid chartId);



        List<EmployeeChart> ShowAll();


    }
}