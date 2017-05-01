using System.Web;
using System.Web.Optimization;

namespace OpenDoors
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/animate.min.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/preloader.min.css"));

            bundles.Add(new StyleBundle("~/Content/css1").Include(
                      "~/Content/main-page-style.css",
                      "~/Content/main/main-carousel.min.css",
                      "~/Content/main/volunteer-images.min.css"
                ));
            bundles.Add(new ScriptBundle("~/Scripts/main").Include(
                    "~/Scripts/site.min.js",
                    "~/Scripts/ru/main/Main-carousel.min.js",
                    "~/Scripts/ru/main/volunteer-image.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                    "~/node_modules/core-js/client/shim.min.js",
                    "~/node_modules/zone.js/dist/zone.js",
                    "~/node_modules/reflect-metadata/Reflect.js",
                    "~/node_modules/systemjs/dist/system.src.js"
                ));

            //bundles.Add(new StyleBundle("~/Content/News/Styles")
            //    .Include("~/Content/SecondLayoutStyle/main.min.css"));

            //bundles.Add(new StyleBundle("~/Content/LeftMenuStyle")
            //    .Include("~/Content/SecondLayoutStyle/LeftMenuStyle.min.css"));

            //bundles.Add(new StyleBundle("~/Content/FooterStyle")
            //    .Include("~/Content/SecondLayoutStyle/FooterStyle.min.css"));

            bundles.Add(new StyleBundle("~/Content/SecondLayoutStyle")
                .Include("~/Content/SecondLayoutStyle/main.min.css")
                .Include("~/Content/SecondLayoutStyle/LeftMenuStyle.min.css")
                .Include("~/Content/SecondLayoutStyle/FooterStyle.min.css"));

            bundles.Add(new ScriptBundle("~/Scripts/SecondLayout")
                .Include("~/Scripts/ru/SecondLayout/leftMenu.js"));

            


            
        }
    }
}
