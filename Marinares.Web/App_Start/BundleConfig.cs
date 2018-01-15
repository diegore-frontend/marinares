using System.Web.Optimization;

namespace Marinares.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/marinares/frameworks").Include(
                "~/Scripts/angular.min.js",
				"~/Scripts/jquery-3.1.1.min.js"));

            bundles.Add(new ScriptBundle("~/marinares/validations").Include(
                "~/Scripts/jquery.validate.min.js",
                "~/Scripts/jquery.validate.unobtrusive.min.js"));

            bundles.Add(new ScriptBundle("~/marinares/shared").Include(
                "~/Scripts/jquery.vendors.js",
                "~/Scripts/site.js"));

            bundles.Add(new ScriptBundle("~/marinares/ng-contact").Include(
                "~/app/contact/contact.service.js",
                "~/app/contact/contact.controller.js"));

            bundles.Add(new ScriptBundle("~/marinares/ng-shared").Include(
                "~/app/shared/services/http.service.js"));

            bundles.Add(new ScriptBundle("~/marinares/ng-modules").Include(
                "~/app/app.module.js",
                "~/app/shared/swal.module.js"));
        }
    }
}
