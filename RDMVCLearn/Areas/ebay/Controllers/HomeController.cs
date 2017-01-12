using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RDMVCLearn.Areas.ebay.Controllers
{
    public class HomeController : Controller
    {
        // GET: ebay/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}