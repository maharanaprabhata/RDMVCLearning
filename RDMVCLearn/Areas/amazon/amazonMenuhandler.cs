using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

static partial class Menuhandler
{
    public static void amazonMenuhandler(ref string controllerName, ref string viewName, ref string areaName)
    {
        areaName = "amazon";
        controllerName = "Home";
        viewName = "Index";
    }
}
