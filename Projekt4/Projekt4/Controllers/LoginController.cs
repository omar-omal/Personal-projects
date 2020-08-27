using Projekt4.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt4.Controllers
{
    public class LoginController : Controller
    {
        Interaktiva_gAEntities db = new Interaktiva_gAEntities();
        // GET: Login

        public ActionResult Login(account User)
        {
            var Usr = db.account.Where(u => u.username == User.username && u.password == User.password).FirstOrDefault();
            if (Usr == null)
            {
                return View("Login");
            }
            else
            {
                Session["id"] = Usr.id;
                Session["username"] = Usr.username;
                Session["admin"] = Usr.admin;
                Session["firstname"] = Usr.firstname;
                Session["lastname"] = Usr.lastname;
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Logout()
        {
            int UsrId = (int)Session["id"];
            Session.Abandon();
            return RedirectToAction("Login");
        }

    }
}