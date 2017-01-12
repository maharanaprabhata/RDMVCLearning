using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RDMVCLearn.Areas.amazon.Controllers
{
    public class HomeController : Controller
    {
        // GET: amazon/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}