using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DesignForm.Models;
using Focus.Common.DataStructs;
using Focus.Security.DataStructs;
using System.IO;

namespace DesignForm.Controllers
{

    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string strFileName)
        {
            if (strFileName == null)
            {
                PasswordPolicy objPasswordPolicy = new PasswordPolicy();
                objPasswordPolicy.DNAPrevious = 1;
                return View(objPasswordPolicy);
            }
            else
            {
                string strPath = @"F:\NighaSir\Day_1\DesignForm\DesignForm\PolicyName\" + strFileName + ".xml";
                PasswordPolicy objPasswordPolicy = (PasswordPolicy)ExportImport.Import(strPath, typeof(PasswordPolicy));
                ViewBag.value = "readonly";
                return View(objPasswordPolicy);
            }
        }
        [HttpPost]
        public ActionResult Save(PasswordPolicy objPasswordPolicy, string strcommand)
        {
            if (strcommand == "Save")
            {
                ExportImport.Export(@"F:\NighaSir\Day_1\DesignForm\DesignForm\PolicyName\" + objPasswordPolicy.PolicyName + ".xml", objPasswordPolicy);
            }
            if (strcommand == "Delete")
            {
                System.IO.File.Delete(@"F:\NighaSir\Day_1\DesignForm\DesignForm\PolicyName\" + objPasswordPolicy.PolicyName + ".xml");
            }
            return RedirectToAction("check");
        }

        public ActionResult Indexs()
        {
            return View();
        }
        public ActionResult check(string strFileName)
        {
            if (strFileName == null)
            {
                PasswordPolicy objPasswordPolicy = new PasswordPolicy();
                objPasswordPolicy.DNAPrevious = 1;
                return View(objPasswordPolicy);
            }
            else
            {
                string strPath = @"F:\NighaSir\Day_1\DesignForm\DesignForm\PolicyName\" + strFileName + ".xml";
                PasswordPolicy objPasswordPolicy = (PasswordPolicy)ExportImport.Import(strPath, typeof(PasswordPolicy));
                ViewBag.value = "readonly";
                return View(objPasswordPolicy);
            }
        }
        public ActionResult PasswordPolicy(string strFileName)
        {
            if (strFileName == null)
            {
                return View();
            }
            else
            {
                string strPath = @"F:\NighaSir\Day_1\DesignForm\DesignForm\PolicyName\" + strFileName + ".xml";
                PasswordPolicy objPasswordPolicy = (PasswordPolicy)ExportImport.Import(strPath, typeof(PasswordPolicy));
                //ViewBag.passwordPolicy = objPasswordPolicy;
                return View(objPasswordPolicy);
            }
        }

        public ActionResult Import(string strFileName)
        {
            string strPath = @"F:\NighaSir\Day_1\DesignForm\DesignForm\PolicyName\" + strFileName + ".xml";
            PasswordPolicy objPasswordPolicy = (PasswordPolicy)ExportImport.Import(strPath, typeof(PasswordPolicy));
            return View(objPasswordPolicy);
        }

        public ActionResult SubMenuDesign()
        {
            return View();
        }


        public ActionResult SubMenu()
        {
                return View();
        }
    }
}