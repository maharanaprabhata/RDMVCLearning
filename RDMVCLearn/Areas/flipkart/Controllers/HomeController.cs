using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RDMVCLearn.Areas.flipkart.Controllers
{
    public class HomeController : Controller
    {
        // GET: flipkart/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}