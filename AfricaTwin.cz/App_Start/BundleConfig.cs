using System.Web;
using System.Web.Optimization;

namespace AfricaTwin.cz
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/sb-admin-2.js"));

            bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                        //"~/Scripts/plugins/dataTables/dataTables.bootstrap.js",
                        //"~/Scripts/plugins/dataTables/jquery.dataTables.js",
                        //"~/Scripts/plugins/flot/excanvas.min.js",
                        //"~/Scripts/plugins/flot/flot-data.js",
                        //"~/Scripts/plugins/flot/jquery.flot.js",
                        //"~/Scripts/plugins/flot/jquery.flot.pie.js",
                        //"~/Scripts/plugins/flot/jquery.flot.resize.js",
                        //"~/Scripts/plugins/flot/jquery.flot.tooltip.min.js",
                        "~/Scripts/plugins/metisMenu/metisMenu.min.js",
                        //"~/Scripts/plugins/morris/morris-data.js",
                        //"~/Scripts/plugins/morris/morris.min.js",
                        "~/Scripts/plugins/morris/raphael.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/sb-admin-2.css",
                      "~/Content/plugins/metisMenu/metisMenu.min.css",
                      "~/Content/plugins/dataTables.bootstrap.css",
                      "~/Content/plugins/morris.css",
                      "~/Content/plugins/social-buttons.css",
                      "~/Content/plugins/timeline.css",
                      "~/Content/site.css"));
        }
    }
}
