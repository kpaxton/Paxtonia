using System.Web.Optimization;

namespace Paxtonia
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{

			//SCRIPTS Bundles
			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
				"~/Scripts/jquery/jquery.unobtrusive*",
				"~/Scripts/jquery/jquery.validate*"));

			bundles.Add(new ScriptBundle("~/bundles/app").Include(
				"~/Scripts/jquery/jquery-{version}.js",
				"~/Scripts/jquery/jquery-ui-{version}.js",
				"~/Scripts/bootstrap/bootstrap.js",
				"~/Scripts/jquery/jquery.cookie.js",
				"~/Scripts/jquery/jquery.nicescroll.js",
				"~/Scripts/modernizr/modernizr-{version}.js",
				"~/Scripts/placeholdr.js",
				"~/Scripts/application.js"
				));

			bundles.Add(new ScriptBundle("~/bundles/html5support").Include(
				"~/Scripts/respond/respond*",
				"~/Scripts/html5shiv/html5shiv*"));

			
			//CSS/LESS Bundles
			bundles.Add(new LessBundle("~/Content/app").Include(
				 "~/Content/less/styles.less"));
			
		}
	}
}