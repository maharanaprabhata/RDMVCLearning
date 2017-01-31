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
        public ActionResult Default()
        {
            return RedirectToAction("Index","Home",new {area="flipkart",HttpMethod = FormMethod.Post });
        }
    }
}