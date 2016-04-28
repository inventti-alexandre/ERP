using System.Web.Mvc;

namespace WebApplicationMVC.Areas.WorkFlow
{
    public class WorkFlowAreaRegistration : AreaRegistration 
    {
        public override string AreaName => "WorkFlow";

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "WorkFlow_default",
                "WorkFlow/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}