using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Index.";

            return View();
        }

        public ActionResult Semester5()
        {
            ViewBag.Message = "Semester 5.";

            return View();
        }

        public ActionResult Testimonial()
        {
            ViewBag.Message = "Student quotes.";

            return View();
        }
    }
}