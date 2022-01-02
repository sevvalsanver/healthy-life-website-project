using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_project.Models;

namespace web_project.Controllers
{
    public class LoginController : Controller
    {
        SiteContext db = new SiteContext();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            List<users> user = db.Users.ToList();
            return View(user);
        }

       /*[ HttpPost]
        public ActionResult SignUp(Users user)
        {

        }*/
    }
}