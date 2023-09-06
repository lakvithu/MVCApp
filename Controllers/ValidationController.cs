using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class ValidationController : Controller
    {
        // GET: Validation
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Page1(Company com)
        {
            if (ModelState.IsValid)
            {
                return View();
            }

            return View();
        }

        public ActionResult Page2(Company c)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View();
        }

        public ActionResult AjaxCode()
        {
            return View();
        }

        public ActionResult DataBind()
        {
            
            return View();
        }

        public ActionResult ShowData()
        {
            EmployeeEntities1 obj = new EmployeeEntities1();
            List<Register> l = new List<Register>();
            var result = from s in obj.registers select s;
            foreach(var x in result)
            {
                Register obj1 = new Register();
                obj1.Id = x.id;
                obj1.Name = x.name;
                obj1.Address = x.address;
                l.Add(obj1);

            }
            return Json(l, JsonRequestBehavior.AllowGet);

        }
    }
}