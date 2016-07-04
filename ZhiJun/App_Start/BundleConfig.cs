using System.Web;
using System.Web.Optimization;

namespace ZhiJun
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                        "~/css/plugins/select_option1.css",
                        "~/css/bootstrap/bootstrap.min.css",
                        "~/fonts/font-awesome/css/font-awesome.min.css",
                        "~/css/plugins/flexslider.css",
                        "~/css/plugins/fullcalendar.min.css",
                        "~/css/plugins/animate.css",
                        "~/css/plugins/magnific-popup.css",
                        "~/css/style.css",
                        "~/css/colors/default.css",
                        "~/js/plugins/bootstrap-datepicker/css/bootstrap-datepicker.min.css",
                        "~/js/plugins/bootstrap-datepicker/css/bootstrap-datepicker3.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/js/jquery.min.js",
                        "~/js/bootstrap/bootstrap.min.js",
                        "~/js/plugins/jquery.flexslider.js",
                        "~/js/plugins/jquery.selectbox-0.1.3.min.js",
                        "~/js/plugins/jquery.magnific-popup.js",
                        "~/js/plugins/waypoints.min.js",
                        "~/js/plugins/jquery.counterup.js",
                        "~/js/plugins/wow.min.js",
                        "~/js/plugins/navbar.js",
                        "~/js/plugins/moment.min.js",
                        "~/js/plugins/fullcalendar.min.js",
                        "~/js/custom.js",
                        "~/js/plugins/bootstrap-datepicker/js/bootstrap-datepicker.min.js",
                        "~/js/plugins/bootstrap-datepicker/locales/bootstrap-datepicker.zh-CN.min.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
