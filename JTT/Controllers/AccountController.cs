using JTT.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JTT.Models;
using System.Data;
namespace JTT.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel obj)
        {
            if (obj == null) { return View(); }

            else
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter("Sp_Login", conn);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.AddWithValue("@email", obj.email);
                    sda.SelectCommand.Parameters.AddWithValue("@password", obj.password);

                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        UserDetailsModel userDetails = new UserDetailsModel();
                        userDetails.id = Convert.ToInt32(dt.Rows[0]["id"]);
                        userDetails.Name = dt.Rows[0]["name"].ToString();
                        userDetails.Email = dt.Rows[0]["email"].ToString();
                        //userDetails.Address=dt.Rows[0]["address"].ToString();
                        //userDetails.DOB = Convert.ToDateTime(dt.Rows[0][""])
                        return RedirectToAction("Dashboard", "Admin",userDetails);
                    }
                    else { 
                        return View();
                    }
                }
                catch { 

                    return View();
                }
            }

        }
    }
}