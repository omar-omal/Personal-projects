using Projekt4.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt4.Controllers
{
    public class AccountController : Controller
    {
        Interaktiva_gAEntities db = new Interaktiva_gAEntities();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Account()
        {
            account newAccount = new account();
            return View(newAccount);
        }

        [HttpPost]
        public ActionResult Account(account newAccount)
        {
            if(ModelState.IsValid)
            {
                db.account.Add(newAccount);
                db.SaveChanges();
            }
            ModelState.Clear();
            return View("Account", new account());
        }

        public ActionResult Login(account User)
        {
            var Usr = db.account.Where(u => u.username == User.username && u.password == User.password).FirstOrDefault();
            if(Usr != null)
            {
                Session["id"] = Usr.id.ToString();
                Session["username"] = Usr.username.ToString();
                return RedirectToAction("LoggedIn");
            }
            else
            {
                ModelState.AddModelError("", "Username or Password is incorrect!");
            }

            return View();
        }

        public ActionResult LoggedIn()
        {
            if(Session["id"] != null)
            {
                return View();
            }

            return RedirectToAction("Login");
        }
    }
}