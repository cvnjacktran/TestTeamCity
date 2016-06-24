using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamCityDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Test command from VS.
            // Test command from VS 2.
            //int a = "3123";



            
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