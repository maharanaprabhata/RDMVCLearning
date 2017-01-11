using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RDMVCLearn;
namespace RDMVCLearn.Controllers
{
    [MyFilter]
    public class FilterController : Controller
    {
        // GET: Filter
        public ActionResult Index()
        {
            int divisior = 0;
            int no = 10 / divisior;
            return View();
        }
    }
}