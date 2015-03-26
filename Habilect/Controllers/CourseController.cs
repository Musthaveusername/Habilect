using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data;

namespace Habilect.Controllers
{
    public class CourseController : Controller
    {
        habtestEntities db = new habtestEntities();

        public ActionResult Index()
        {
            var Courses = db.Courses.Include(c => c.CourseMotions);
            ViewBag.Motions = db.Motions.Include(m => m.Attempts);
            return View(Courses.ToList());
        }

        [HttpGet]
        public ActionResult AddCourse(int id) {

            ViewBag.CourseId = id;
            return View();
        }

        [HttpPost]
        public string AddCourse(Courses course){
            db.Courses.Add(course);
            db.SaveChanges();
            return "Курс добавлен в БД";
        }

    }
}