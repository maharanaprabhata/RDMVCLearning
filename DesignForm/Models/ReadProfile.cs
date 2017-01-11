using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Focus.Common.DataStructs;
using Focus.Security.DataStructs;

namespace DesignForm.Models
{
    public class ReadProfile
    {
       static bool flag = false;
       static DetailedMenuPermission[] objdetailedMenuPermission = null;
        public static DetailedMenuPermission[] Get_detailedMenuPermission()
        {
            if (flag == false)
            {
                objdetailedMenuPermission = (DetailedMenuPermission[])ExportImport.Import(@"F:\NighaSir\Menus.xml", typeof(DetailedMenuPermission[]));
                flag = true;
                return objdetailedMenuPermission;
            }
            else
                return objdetailedMenuPermission;
        }
    }
}