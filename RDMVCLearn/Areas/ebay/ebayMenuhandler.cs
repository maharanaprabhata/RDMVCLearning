using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

static partial class Menuhandler
{
    public static void ebayMenuhandler(ref string controllerName, ref string viewName, ref string areaName)
    {
        areaName = "ebay";
        controllerName = "Home";
        viewName = "Index";
    }
}
