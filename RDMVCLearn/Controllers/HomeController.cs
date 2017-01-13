using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RDMVCLearn.Models;

namespace RDMVCLearn.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult LoadView(MenuHandlerEnum mType=MenuHandlerEnum.amazon)
        {
            string controllerName = "", viewName = "", areaName = "";
            try
            {
                switch (mType)
                {
                    case MenuHandlerEnum.flipkart:
                        Menuhandler.flipkartMenuhandler(ref controllerName, ref viewName, ref areaName);
                        break;
                    case MenuHandlerEnum.amazon:
                        Menuhandler.amazonMenuhandler(ref controllerName, ref viewName, ref areaName);
                        break;
                    case MenuHandlerEnum.ebay:
                        Menuhandler.ebayMenuhandler(ref controllerName, ref viewName, ref areaName);
                        break;
                    case MenuHandlerEnum.shanpdeal:
                        Menuhandler.shanpdealMenuhandler(ref controllerName, ref viewName, ref areaName);
                        break;
                }
            }
            catch (Exception ex)
            {

            }
            if (viewName != "" && controllerName != "")
            {
                return RedirectToAction(viewName, controllerName, new { area = areaName, HttpMethod = FormMethod.Post });
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
        }

        public ActionResult flipkart()
        {
            return RedirectToAction("offer");
        }
        public ActionResult offer()
        {
            return View();
        }
    }
}