using System;
using System.Data.Entity;
using System.Threading;
using System.Web;
using DataLayer.Context;
using DomainLayer.DB_Model.Authentication;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataProtection;
using ServiceLayer.Authentication.Communications;
using ServiceLayer.Authentication.Role.Manager;
using ServiceLayer.Authentication.Role.Store;
using ServiceLayer.Authentication.SignIn;
using ServiceLayer.Authentication.User.Manager;
using ServiceLayer.Authentication.User.Provider;
using ServiceLayer.Authentication.User.Store;
using ServiceLayer.Chart;
using ServiceLayer.ChartEmployee;
using ServiceLayer.Employee;
using ServiceLayer.General.Type;
using StructureMap;
using StructureMap.Web;

namespace ObjectFactory.WinForm
{
    public class WinFormAppObjectFactory
    {
        private static readonly Lazy<Container> ContainerBuilder =
          new Lazy<Container>(MainContainer, LazyThreadSafetyMode.ExecutionAndPublication);

        public static IContainer Container
        {
            get { return ContainerBuilder.Value; }
        }
        
        
        private static Container MainContainer()
        {
            return new Container(ioc =>
            {


                ioc.For<IUnitOfWork>().Use<SharpCoContext>();
                ioc.For<SharpCoContext>().Use<SharpCoContext>();
                ioc.For<DbContext>().Use<SharpCoContext>();





                ioc.For<IUserStore<ApplicationUser, Guid>>()
                  .Use<
                      UserStore
                          <ApplicationUser, ApplicationRole, Guid, ApplicationUserLogin, ApplicationUserRole,
                              ApplicationUserClaim>
                      >();



               


                ioc.For<IRoleStore<ApplicationRole, Guid>>()
                .HybridHttpOrThreadLocalScoped()
                .Use<RoleStore<ApplicationRole, Guid, ApplicationUserRole>>();

                ioc.For<IApplicationUserManager>().Use<ApplicationUserManager>();



                ioc.For<IApplicationRoleManager>()

                    .Use<ApplicatioRoleManager>();
                    //.DecorateWith(x => dynamicProxy.CreateInterfaceProxyWithTarget(x, new CacheInterceptor()));

                ioc.For<IIdentityMessageService>().Use<SmsService>();
                ioc.For<IIdentityMessageService>().Use<EmailService>();
                ioc.For<IDataProtectionProvider>().Use<AppDataProtectionProvider>();


                ioc.For<IApplicationRoleStore>()
                    .Use<ApplicationRoleStore>();

                ioc.For<IApplicationUserStore>()
                    .Use<ApplicationUserStore>();


                ioc.For<IEmployeeService>()
                    .Use<EmployeeService>();

                ioc.For<ITypeService>()
                    .Use<TypeService>();

                ioc.For<IChartService>()
                    .Use<ChartService>();

                ioc.For<IChartEmployeeService>()
                   .Use<ChartEmployeeService>();


            });

        }

    }
}
