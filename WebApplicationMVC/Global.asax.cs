using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ObjectFactory;
using ObjectFactory.MVC;
using StructureMap;
using StructureMap.Web.Pipeline;

namespace WebApplicationMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

         

            //Change Default Controller Factory To Application StructerMap Factory
            ControllerBuilder.Current.SetControllerFactory(new ControllerFactory());
        }


        //Dispose All Object When Request Is Finish
        protected void Application_EndRequest(object sender, EventArgs e)
        {
            HttpContextLifecycle.DisposeAndClearAll();
        }
    }
}