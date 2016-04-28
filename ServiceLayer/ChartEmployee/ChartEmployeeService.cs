using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
using DomainLayer.App_Model.General;
using DomainLayer.DB_Model.EmployeeChart;

namespace ServiceLayer.ChartEmployee
{
    public class ChartEmployeeService:IChartEmployeeService
    {
           
        
        //private readonly IDbSet<DomainLayer.Chart.Chart> _chart;
        private readonly IDbSet<EmployeeChart> _chartEmployee;
        private readonly IUnitOfWork _uow;


        public ChartEmployeeService(IUnitOfWork uow)
        {
            _uow = uow;
            _chartEmployee = _uow.Set<EmployeeChart>();
        }

       

        public async Task<ServicesResult> DisablePrsFromChart(Guid prsId, Guid chartId)
        {

           

            try
            {
                var chartEmployeeModel = _chartEmployee.Find(chartId, prsId);
                if (chartEmployeeModel == null)
                {

                    return new ServicesResult()
                    {
                        ErrorCount = 1,
                        Success = false,
                        Message = "سمت و کاربر یافت نشد"
                    };


                }

                chartEmployeeModel.IsActive = false;

                _uow.MarkAsChanged(chartEmployeeModel);
                await _uow.SaveChangesAsync();

                return new ServicesResult()
                {
                    ErrorCount = 0,
                    Success = true,
                    Message = "سمت کاربر با موفقیت غیرفعال شد"
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

        public async Task<ServicesResult> EnablePrsFromChart(Guid prsId, Guid chartId)
        {
            try
            {
                var chartEmployeeModel = _chartEmployee.Find(chartId, prsId);
                if (chartEmployeeModel == null)
                {

                    return new ServicesResult()
                    {
                        ErrorCount = 1,
                        Success = false,
                        Message = "سمت و کاربر یافت نشد"
                    };


                }

                chartEmployeeModel.IsActive = true;

                _uow.MarkAsChanged(chartEmployeeModel);
                await _uow.SaveChangesAsync();

                return new ServicesResult()
                {
                    ErrorCount = 0,
                    Success = true,
                    Message = "سمت کاربر با موفقیت فعال شد"
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

        public async Task<ServicesResult> JoinPrsToChart(Guid prsId, Guid chartId)
        {
            var employeeChart = new EmployeeChart
            {
                ChartId = chartId,
                AppUserId = prsId,
                IsActive=true

            };


            try
            {
                _chartEmployee.Add(employeeChart);
                await _uow.SaveChangesAsync();
                return new ServicesResult()
                {
                  
                    ErrorCount = 0,
                    Success = true,
                    Message = "کاربر با موفقیت منصوب شد"
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



        public List<EmployeeChart> ShowChartEmployees(Guid chartId)
        {
            return _chartEmployee.Where(w => w.ChartId == chartId).ToList();
        }

        public List<EmployeeChart> ShowAll()
        {
            return _chartEmployee.Where(w => w.IsActive).OrderBy(o=>o.AppUserId).ToList();
        }

        public List<EmployeeChart> ShowEmployeeCharts(Guid prsId)
        {
            return _chartEmployee.Where(w => w.AppUserId == prsId && w.IsActive).ToList();
        }
    }
}
