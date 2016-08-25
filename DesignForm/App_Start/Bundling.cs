using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace DesignForm.App_Start
{
    public class Bundling
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Contents/css").Include("~/Contents/bootstrap.css", "~/Contents/bootstrap.min.css", "~/jquery-ui-1.11.4.custom/jquery-ui.css", "~/jquery-ui-1.11.4.custom/jquery-ui.theme.css", "~/Contents/Design.css"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/scripts/jquery.js", "~/jquery-ui-1.11.4.custom/jquery-ui.js"));
        }
    }
}