using System.Web.Optimization;

namespace Covid_19_Tracking
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/library").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootbox.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/respond.js",
                        "~/Scripts/datatables/jquery.datatables.js",
                        "~/Scripts/DataTables/datatables.bootstrap4.js",
                        "~/Scripts/jquery.unobtrusive-ajax.js",
                        "~/Scripts/typeahead.bundle.js",
                        "~/scripts/toastr.js",
                        "~/scripts/dataTables.responsive.js",
                        "~/scripts/testimonial.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Theme.css",
                      "~/Content/Lumen.css",
                      "~/Content/DataTables/css/datatables.bootstrap4.css",
                      "~/Content/site.css",
                      "~/Content/Typeahead.css",
                      "~/content/toastr.css",
                      "~/content/responsive.dataTables.css"
                      ));
        }
    }
}
