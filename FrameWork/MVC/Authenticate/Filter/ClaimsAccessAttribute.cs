using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FrameWork.MVC.Authenticate.Filter
{
    public class ClaimsAccessAttribute : AuthorizeAttribute
    {
        public string Value { get; set; }


        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (!httpContext.User.Identity.IsAuthenticated) return false;

            if (httpContext.User.Identity is ClaimsIdentity == false) return false;

            if (((ClaimsIdentity) httpContext.User.Identity).Claims.All(c => c.Value != Value)) return false;

            return base.AuthorizeCore(httpContext);
        }
    }
}