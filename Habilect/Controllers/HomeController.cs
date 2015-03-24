using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Habilect.Controllers
{
    public class HomeController : Controller
    {



        public ActionResult Index()
        {
            habtestEntities db = new habtestEntities();
            IEnumerable<Courses> CourseList = db.Courses;
            ViewBag.Courses = CourseList;
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