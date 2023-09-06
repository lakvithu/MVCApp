using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;
using System.Data;
using System.Data.SqlClient;

namespace MVCApp.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            EmployeeEntities obj = new EmployeeEntities();
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
            return View(l);
        }

        public ActionResult Register1()
        {
            /*SqlConnection con = new SqlConnection("Data source=DESKTOP-EKHLQS1\\SQLEXPRESS;Database=Employee;Integrated Security=true");
            con.Open();
            string query3 = "select * from register";
            SqlCommand cmd = new SqlCommand(query3, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            List<Register> l = new List<Register>();
            Register obj = new Register();
            if(dt.Rows.Count>0)
            {
                l = (from DataRow in dt.Rows select obj).

            }*/

            return View();
        }

        public ActionResult Register2()
        {
            return View();
        }

        }
    }
