using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class ValidExampleController : Controller
    {
        // GET: Valid

        [HttpPost]
        public ActionResult Index(Doctor d)
        {
            if(ModelState.IsValid)
            {
                return View();
            }
            return View();
        }

        [HttpPost]
        public ActionResult Page1(Doctor d)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View();
        }

    }
}