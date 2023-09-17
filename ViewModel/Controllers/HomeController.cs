using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel.Data;
using ViewModel.Models;

namespace ViewModel.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db;
        public HomeController()
        {
            db = new ApplicationDbContext();
        }
        public HomeController(ApplicationDbContext dbs)
        {
            db = dbs;
        }
        public ActionResult Index1()
        {
            //var std = getStudents();
            //var techr = getTeachers();

            //StdVM data = new StdVM();
            //data.Students = std;
            //data.Teachers = techr;

            //ViewBag.Students = std;
            //ViewBag.Teachers = techr;

            //ViewData["Students"] = std;
            //ViewData["Teachers"] = techr;

            //TempData["Students"] = std;
            //TempData["Teachers"] = techr;

            //Session["Students"] = std;
            //Session["Teachers"] = techr;

            return View();
        }
        public List<Students> getStudents()
        {
            return db.Students.ToList();
        }
        public List<Teachers> getTeachers()
        {
            return db.Teachers.ToList();
        }
        public PartialViewResult Students()
        {
            var std = getStudents();
            return PartialView("_students", std);
        }
        public PartialViewResult Teachers()
        {
            var techr = getTeachers();
            return PartialView("_teacher", techr);
        }
        public ActionResult Index()
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