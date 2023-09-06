using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace MVCApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Display()
        {
            besantEntities obj = new besantEntities();
            List<display> l = obj.displays.ToList();
            return View(l);
        }


        public ActionResult Records()
        {
            Display d = new Display();
            List<Display> l = new List<Display>();
            d.studentId = 1;
            d.studentName = "besant";
            d.studentAge = 10;
            l.Add(d);
            Display d1 = new Display();
            d1.studentId = 2;
            d1.studentName = "anand";
            d1.studentAge = 21;
            //DataTable dt = ds.Tables[0];
            l.Add(d1);
            return View(l);
        }

           






    }
}