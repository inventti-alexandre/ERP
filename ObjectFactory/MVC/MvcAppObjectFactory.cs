using System;
using System.Data.Entity;
using System.Threading;
using System.Web;
using AOP.Cache;
using Castle.DynamicProxy;
using DataLayer.Context;
using DomainLayer.DB_Model.Authentication;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using ServiceLayer.Authentication.Communications;
using ServiceLayer.Authentication.Role.Manager;
using ServiceLayer.Authentication.Role.Store;
using ServiceLayer.Authentication.SignIn;
using ServiceLayer.Authentication.User.Manager;
using ServiceLayer.Authentication.User.Store;
using ServiceLayer.Chart;
using ServiceLayer.Employee;
using ServiceLayer.File;
using ServiceLayer.General.Type;
using ServiceLayer.News;
using ServiceLayer.Session;
using StructureMap;
using StructureMap.Web;
using ServiceLayer.ChartEmployee;
using ServiceLayer.WorkFlow.DocSend;
using ServiceLayer.WorkFlow.Document;
using ServiceLayer.WorkFlow.Send;

namespace ObjectFactory.MVC
{
    public static class MvcAppObjectFactory
    {
        private static readonly Lazy<Container> ContainerBuilder =
            new Lazy<Container>(MainContainer, LazyThreadSafetyMode.ExecutionAndPublication);


        public static IContainer Container => ContainerBuilder.Value;


        private static Container MainContainer()
        {
            return new Container(ioc =>
            {
                var dynamicProxy = new ProxyGenerator();


                ioc.For<IUnitOfWork>()
                    .HybridHttpOrThreadLocalScoped()
                    .Use<SharpCoContext>();

                ioc.For<SharpCoContext>().HybridHttpOrThreadLocalScoped().Use<SharpCoContext>();
                ioc.For<DbContext>().HybridHttpOrThreadLocalScoped().Use<SharpCoContext>();


                ioc.For<IUserStore<ApplicationUser, Guid>>()
                    .HybridHttpOrThreadLocalScoped()
                    .Use<
                        UserStore
                            <ApplicationUser, ApplicationRole, Guid, ApplicationUserLogin, ApplicationUserRole,
                                ApplicationUserClaim>
                        >();


                ioc.For<IRoleStore<ApplicationRole, Guid>>()
                    .HybridHttpOrThreadLocalScoped()
                    .Use<RoleStore<ApplicationRole, Guid, ApplicationUserRole>>();

                ioc.For<IAuthenticationManager>()
                    .Use(() => HttpContext.Current.GetOwinContext().Authentication);


                ioc.For<IApplicationSignInManager>()
                    .HybridHttpOrThreadLocalScoped()
                    .Use<ApplicationSignInManager>();

                ioc.For<IApplicationUserManager>()
                    .HybridHttpOrThreadLocalScoped()
                    .Use<ApplicationUserManager>();

                ioc.For<IApplicationRoleManager>()
                    .HybridHttpOrThreadLocalScoped()
                    .Use<ApplicatioRoleManager>()
                    .DecorateWith(x => dynamicProxy.CreateInterfaceProxyWithTarget(x, new CacheInterceptor()));

                ioc.For<IIdentityMessageService>().Use<SmsService>();
                ioc.For<IIdentityMessageService>().Use<EmailService>();

                ioc.For<IApplicationRoleStore>()
                    .HybridHttpOrThreadLocalScoped()
                    .Use<ApplicationRoleStore>();

                ioc.For<IApplicationUserStore>()
                    .HybridHttpOrThreadLocalScoped()
                    .Use<ApplicationUserStore>();


                ioc.For<ITypeService>()
                 .HybridHttpOrThreadLocalScoped()
                 .Use<TypeService>();


                ioc.For<IEmployeeService>()
                    .DecorateAllWith(x => dynamicProxy.CreateInterfaceProxyWithTarget(x, new CacheInterceptor()))
                    .HybridHttpOrThreadLocalScoped()
                    .Use<EmployeeService>();

                ioc.For<IFileService>()
                    .HybridHttpOrThreadLocalScoped()
                    .Use<FileServise>();

                ioc.For<IChartService>()
                   .HybridHttpOrThreadLocalScoped()
                   .Use<ChartService>();

                ioc.For<IChartEmployeeService>()

                  .HybridHttpOrThreadLocalScoped()
                  .Use<ChartEmployeeService>();

                ioc.For<INewsGroupServices>()
                 .HybridHttpOrThreadLocalScoped()
                 .Use<NewsGroupServices>();

                ioc.For<INewsServices>()
                 .HybridHttpOrThreadLocalScoped()
                 .Use<NewsServices>();

                ioc.For<IDocumentService>()
               .HybridHttpOrThreadLocalScoped()
               .Use<DocumentService>();


                ioc.For<ISendService>()
                    .HybridHttpOrThreadLocalScoped()
                    .Use<SendService>();

                ioc.For<IDocSendService>()
              .HybridHttpOrThreadLocalScoped()
              .Use<DocSendService>();




                // session manager setup
                ioc.For<ISessionProvider>().Use<WebSessionProvider>();
                ioc.For<HttpSessionStateBase>()
                    .Use(ctx => new HttpSessionStateWrapper(HttpContext.Current.Session));
                ioc.Policies.SetAllProperties(properties => properties.OfType<ISessionProvider>());


                //config.For<IDataProtectionProvider>().Use(()=> app.GetDataProtectionProvider()); // In Startup class
            });
        }
    }
}