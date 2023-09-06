using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using MVCApp.Models;
using System.Data;
using System.Web.Security;
using System.Configuration;

namespace MVCApp.Controllers
{
    public class RegisterController : Controller
    {
        static string strcon = ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registration()
        {
            try
            {
               // SqlConnection con = new SqlConnection("Data source=DESKTOP-EKHLQS1\\SQLEXPRESS;Database=Employee;Integrated Security=true");
                con.Open();
                string query3 = "select * from register";
                SqlCommand cmd = new SqlCommand(query3, con);

                SqlDataReader dr = cmd.ExecuteReader();
                List<Register> l = new List<Register>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Register r = new Register();

                        int id = Convert.ToInt32(dr["id"]);
                        string name = dr["name"].ToString();
                        string add = dr["add"].ToString();

                        r.Name = name;
                        r.Address = add;
                        l.Add(r);
                    }
                }
                con.Close();

            }

            finally { }
           
            return View(1);
        }

        public ActionResult Insert()
        {
            con.Open();
            int id = Convert.ToInt32(Request.Form["id"]);
            string name = Request.Form["name"];
            int age = Convert.ToInt32(Request.Form["age"]);
            int marks = Convert.ToInt32(Request.Form["marks"]);
            string addr = Request.Form["addr"];
            string query = "insert into student(id,name,age,marks,addr) values(@id,@name,@age,@marks,@addr)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@marks", marks);
            cmd.Parameters.AddWithValue("@addr", addr);
            cmd.ExecuteNonQuery();
            con.Close();

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult SessionPage()
        {
            
            int id = Convert.ToInt32(Request.Form["id"]);
            string name = Request.Form["username"];
            string query = "select id,name from register where id=@id and name=@name";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                //session create
                Session["username"] = name;
                ViewBag.name = Session["username"];
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
            
        }
        
        public ActionResult NextPage()
        {
            if (HttpContext.Session["username"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }


        }
        public ActionResult Logout()
        {
            if(HttpContext.Session["username"]!=null)
            {
                //destroy the session
                FormsAuthentication.SignOut();
                return View();

            }

            return View();
            
        }
    }
}