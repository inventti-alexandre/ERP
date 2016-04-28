using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FrameWork.MVC.Helper
{
    public static class HtmlHelperExtention
    {

        public static IHtmlString ActionLinkWithIcon(this HtmlHelper htmlHelper, string linkText, string action, string controller, object routeValues, object htmlAttributes,string iconeClassName)
        {
            var urlHelper = new UrlHelper(htmlHelper.ViewContext.RequestContext);

            var icon = new TagBuilder("i") {};
            icon.Attributes["class"] = iconeClassName;
            icon.Attributes["style"] = "padding-left: 5px;";

            var anchor = new TagBuilder("a")
            {
                InnerHtml =icon+ " " + linkText
            };
            anchor.Attributes["href"] = urlHelper.Action(action, controller, routeValues);

            anchor.MergeAttributes(new RouteValueDictionary(htmlAttributes));
            return MvcHtmlString.Create(anchor.ToString());
        }


    }
}
