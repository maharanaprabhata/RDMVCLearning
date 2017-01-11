using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DesignForm.Models;
using Focus.Common.DataStructs;

namespace DesignForm.Controllers
{
    public class Task1FinalController : Controller
    {
        // GET: Task1Final
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
            return RedirectToAction("Index");
        }
    }
}