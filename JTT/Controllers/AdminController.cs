using JTT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JTT.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Dashboard(UserDetailsModel user)
        {
            return View(user);
        }
    }
}