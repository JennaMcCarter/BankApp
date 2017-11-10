using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            // Change from template code to app specific - JM
            ViewBag.Message = "Meow Banking app for AltSource";
            return View();
        }

        public ActionResult Contact()
        {
            // Change from template code to app specific - JM
            ViewBag.Message = "Contact us Meow!";
            return View();
        }
    }
}