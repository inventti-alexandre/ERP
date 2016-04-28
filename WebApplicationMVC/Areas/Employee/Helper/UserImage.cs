using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using StructureMap.Query;

namespace WebApplicationMVC.Areas.Employee.Helper
{
    public static class UserImage
    {



       

        public static MvcHtmlString EmployeeImage(this HtmlHelper htmlHelper, byte[] content)
        {

            if (content == null)
            {
                var lbl = new TagBuilder("label");
                lbl.SetInnerText("Not Found Image");
                return MvcHtmlString.Create(lbl.ToString(TagRenderMode.SelfClosing));
            }


            var base64 = Convert.ToBase64String(content);
            var imgSrc = $"data:image/gif;base64,{base64}";
            var img = new TagBuilder("img");
            img.MergeAttribute("src", imgSrc);
            img.MergeAttribute("alt", "Not Found");
            return MvcHtmlString.Create(img.ToString(TagRenderMode.SelfClosing));

          
        }

      



    }
}