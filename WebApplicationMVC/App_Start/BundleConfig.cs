using System.Web;
using System.Web.Optimization;

namespace WebApplicationMVC
{
    public class BundleConfig
    {
    
        public static void RegisterBundles(BundleCollection bundles)
        {



            //-General Custom
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/fontface.css",
                "~/Content/css/site.css",
                "~/Content/css/SideMenu.css"
               ));


           //--Jquery
            bundles.Add(new ScriptBundle("~/Script/jquery").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/appJs/GeneralUtility.js"
                ));

            bundles.Add(new ScriptBundle("~/Script/jqueryval").Include(
                 "~/Scripts/jquery-validate.min.js"
                ));


            //--Modernizer
            bundles.Add(new ScriptBundle("~/Script/modernizr").Include(
                "~/Scripts/modernizr-*"
               ));


            //--Bootstrap
            bundles.Add(new ScriptBundle("~/Script/Bootstrap").Include(
               "~/Scripts/bootstrap-rtl.js"));
           
            bundles.Add(new StyleBundle("~/Content/Bootstrap").Include(
               "~/Content/css/bootstrap-rtl.css",
               "~/Content/font-awesome.css"
              ));

            //--CkEditor
            bundles.Add(new ScriptBundle("~/Script/Editor").Include(
              "~/Scripts/ckeditor/ckeditor.js",
              "~/Scripts/ckeditor/styles.js",
              "~/Scripts/ckeditor/config.js"));

            bundles.Add(new StyleBundle("~/Content/Editor").Include(
             "~/Scripts/ckeditor/contents.css"));


            //--jsTree
            bundles.Add(new ScriptBundle("~/Script/jsTree").Include(
           "~/Scripts/jstree.min.js"));
            
            bundles.Add(new StyleBundle("~/Content/jsTree").Include(
            "~/Content/themes/default/style.min.css"));

            //Sweet Alert
            bundles.Add(new StyleBundle("~/Content/SweetAlert").Include(
                "~/Styles/sweetalert.css"));
            bundles.Add(new ScriptBundle("~/Script/SweetAlert").Include(
              "~/Scripts/sweetalert.min.js"));


            //Grid.MVC
            bundles.Add(new StyleBundle("~/Content/GridMvc").Include(
               "~/Content/Gridmvc.css"));

            bundles.Add(new ScriptBundle("~/Script/GridMvc").Include(
             "~/Scripts/gridmvc.min.js",
             "~/Scripts/appjs/GridUtility.js"));



            //WorkFlowJs
            bundles.Add(new ScriptBundle("~/Script/workflowJs").Include(
            "~/Scripts/appJs/WorkFlowjs.js"));




           

        }
    }
}