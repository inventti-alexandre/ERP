using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace ObjectFactory.MVC
{
    public class ControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null)
                throw new InvalidOperationException($"Page not found: {requestContext.HttpContext.Request.RawUrl}");


            return MvcAppObjectFactory.Container.GetInstance(controllerType) as Controller;
        }
    }
}