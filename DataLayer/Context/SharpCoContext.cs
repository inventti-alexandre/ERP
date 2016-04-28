using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using DataLayer.Mapping.Authrnticate;
using DataLayer.Mapping.Employee;
using DataLayer.Mapping.File;
using DataLayer.Properties;
using DomainLayer.DB_Model.Authentication;
using DomainLayer.DB_Model.Chart;
using DomainLayer.DB_Model.Documents;
using DomainLayer.DB_Model.Employee;
using DomainLayer.DB_Model.EmployeeChart;
using DomainLayer.DB_Model.News;
using DomainLayer.DB_Model.Send;
using DomainLayer.DB_Model.Title;
using Microsoft.AspNet.Identity.EntityFramework;
using Type = DomainLayer.DB_Model.General.Type;


namespace DataLayer.Context
{
    [UsedImplicitly]
    public class SharpCoContext :
        IdentityDbContext
            <ApplicationUser, ApplicationRole, Guid, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>,
        IUnitOfWork
    {
        #region Tables

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Chart> Chart { get; set; }
        public DbSet<Type> Type { get; set; }
        public DbSet<EmployeeChart> EmployeeCharts { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsGroup> NewsGroup { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Send> Send { get; set; }
        public DbSet<Title> Titles { get; set; }

        public DbSet<DocHistory> DocumentHistory { get; set; }
        

        #endregion Tables

        #region Constructor

        public SharpCoContext()
            : base("Server=.;Database=SharpCO;User ID=sa;Password=1234;MultipleActiveResultSets=true")
        {
            Database.Log = sql => Debug.Write(sql);
            //this.Configuration.ProxyCreationEnabled = false;
        }

        #endregion Constructor

        #region Unit Of Work

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
        public void MarkAsChanged<TEntity>(TEntity entity) where TEntity : class
        {
            Entry(entity).State = EntityState.Modified;
        }

        public IList<T> GetRows<T>(string sql, params object[] parameters) where T : class
        {
            return Database.SqlQuery<T>(sql, parameters).ToList();
        }

        public void ForceDatabaseInitialize()
        {
            Database.Initialize(true);
        }

        #endregion Unit Of Work

        #region DBContext Ovverride

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SetMappingToContext(modelBuilder);
        }

        #endregion DBContext Ovverride

        #region SetMapping

        private static void SetMappingToContext(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeConfig());
            
            modelBuilder.Configurations.Add(new Mapping.Chart.ChartConfig());
            modelBuilder.Configurations.Add(new Mapping.EmployeeChart.EmployeeChartConfig());

            modelBuilder.Configurations.Add(new FileConfig());

            modelBuilder.Configurations.Add(new Mapping.General.TypeConfig());

            modelBuilder.Configurations.Add(new Mapping.News.NewsConfig());
            modelBuilder.Configurations.Add(new Mapping.News.NewsGroupConfig());

            modelBuilder.Configurations.Add(new Mapping.Documents.DocumentsConfig());
            modelBuilder.Configurations.Add(new Mapping.Documents.DocHistoryConfig());

            modelBuilder.Configurations.Add(new Mapping.Send.SendConfig());

            modelBuilder.Configurations.Add(new Mapping.Title.TitleConfig());

           


            //Identity System set maping
            AppUserConfig.SetConfig(modelBuilder);
            AppRoleConfig.SetConfig(modelBuilder);
            AppUserRoleConfig.SetConfig(modelBuilder);
            AppUserLoginConfig.SetConfig(modelBuilder);
            AppUserClaimConfig.SetConfig(modelBuilder);
        }

        #endregion SetMapping
    }
}