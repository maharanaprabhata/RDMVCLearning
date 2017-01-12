using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

static partial class Menuhandler
{
    public static void shanpdealMenuhandler(ref string controllerName, ref string viewName, ref string areaName)
    {
        areaName = "shanpdeal";
        controllerName = "Home";
        viewName = "Index";
    }
}
