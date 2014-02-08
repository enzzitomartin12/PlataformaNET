using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Mostrando ASP.NET MVC";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
