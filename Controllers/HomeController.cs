using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sagenoti1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Supervisor()
        {
            return View();
        }
        public ActionResult Headmaster()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}