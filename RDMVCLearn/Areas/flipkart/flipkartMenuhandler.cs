using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

static partial class Menuhandler
{
    public static void flipkartMenuhandler(ref string controllerName, ref string viewName, ref string areaName)
    {
        areaName = "flipkart";
        controllerName = "Home";
        viewName = "Index";
    }
}
