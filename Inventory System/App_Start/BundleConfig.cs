using System.Web;
using System.Web.Optimization;

namespace Inventory_System
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").
                Include(
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/respond.js",
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/DataTables/jquery.dataTables.js",
                        "~/Scripts/DataTables/dataTables.bootstrap.js",
                        "~/Scripts/bootbox.js",
                        "~/Scripts/typeahead.bundle.js",
                        "~/Scripts/jquery.cookie.js",
                        "~/Scripts/toastr.js"  
                        )
                        );
            bundles.Add(new ScriptBundle("~/bundles/slider").Include(
                     "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/Slider/Slider.js",
                        "~/Scripts/Slider/automatic-slider.js",
                        "~/Scripts/Slider/automatic-slider.js"
                )
                );

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      //"~/Content/-lumen.css",
                      "~/Content/lumen.css",
                      "~/Content/toastr.css",
                      "~/Content/Slider.css",
                      "~/Content/typeahead.css",
                      "~/Content/DataTables/css/dataTables.bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
