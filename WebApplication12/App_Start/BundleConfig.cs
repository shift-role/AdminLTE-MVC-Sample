using System.Web.Optimization;
using WebHelpers.Mvc5;

namespace WebApplication12
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Bundles/css")
                .Include("~/bower_components/bootstrap/dist/css/bootstrap.css", new CssRewriteUrlTransformAbsolute())
                .Include("~/bower_components/select2/dist/css/select2.css")
                .Include("~/bower_components/bootstrap-datepicker/dist/css/bootstrap-datepicker3.css")
                .Include("~/bower_components/font-awesome/css/font-awesome.css", new CssRewriteUrlTransformAbsolute())
                .Include("~/bower_components/admin-lte/plugins/iCheck/minimal/blue.css", new CssRewriteUrlTransformAbsolute())
                .Include("~/bower_components/admin-lte/dist/css/AdminLTE.css", new CssRewriteUrlTransformAbsolute())
                .Include("~/bower_components/admin-lte/dist/css/skins/skin-blue.css"));

            bundles.Add(new ScriptBundle("~/Bundles/js")
                .Include("~/bower_components/respond/dist/respond.src.js")
                .Include("~/Scripts/modernizr-*")
                .Include("~/bower_components/jquery/dist/jquery.js")
                .Include("~/bower_components/admin-lte/plugins/jQueryUI/jquery-ui.js")
                .Include("~/bower_components/bootstrap/dist/js/bootstrap.js")
                .Include("~/bower_components/fastclick/lib/fastclick.js")
                .Include("~/bower_components/jquery-slimscroll/jquery.slimscroll.js")
                .Include("~/bower_components/select2/dist/js/select2.full.js")
                .Include("~/bower_components/moment/moment.js")
                .Include("~/bower_components/bootstrap-datepicker/dist/js/bootstrap-datepicker.js")
                .Include("~/bower_components/admin-lte/plugins/iCheck/icheck.js")
                .Include("~/bower_components/inputmask/dist/jquery.inputmask.bundle.js")
                .Include("~/bower_components/admin-lte/dist/js/adminlte.js")
                .Include("~/Scripts/app.js")
                .Include("~/Scripts/init.js"));

#if DEBUG
            BundleTable.EnableOptimizations = false;
#else
            BundleTable.EnableOptimizations = true;
#endif
        }
    }
}
