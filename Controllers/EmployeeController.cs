using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }

        public string UserName(string name)
        {
            return name;
        }

        [Route("MVCTest/{studentName ?}")]
        public ActionResult MVC(string studentName)
        {
            ViewBag.Message = "Asp.net app";
            ViewBag.result = studentName;
            return View();
        }

        public ActionResult Insert()
        {
            SqlConnection con = new SqlConnection("Data source=DESKTOP-EKHLQS1\\SQLEXPRESS;Database=Employee;Integrated Security=true");
            con.Open();
            int id = Convert.ToInt32(Request.Form["id"]);
            string name = Request.Form["uname"];
            string address = Request.Form["address"];
            string query = "insert into register(id,name,address) values(@id,@name,@address)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("id", @id);
            cmd.Parameters.AddWithValue("name", @name);
            cmd.Parameters.AddWithValue("address", @address);
            cmd.ExecuteNonQuery();
            return View();
        }

       
        public ActionResult Display()
        {
            SqlConnection con = new SqlConnection("Data source=DESKTOP-EKHLQS1\\SQLEXPRESS;Database=Employee;Integrated Security=true");
            con.Open();
            string query = "select * from register";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult PartialViewDemo()
        {
            return View();
        }

        public ActionResult UserData()
        {
            return View();
        }

    }
}