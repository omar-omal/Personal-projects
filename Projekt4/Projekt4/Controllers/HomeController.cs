using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projekt4.Models.db;
using Projekt4.Models;
using System.Data.Entity;

namespace Projekt4.Controllers
{
    public class HomeController : Controller
    {
        Interaktiva_gAEntities db = new Interaktiva_gAEntities();


        public ActionResult Index()
        {

            ViewBag.Channels = db.channel.OrderBy(c => c.name).ToList();
            ViewBag.newslist = db.news.ToList();
            return View(db.program.OrderBy(x => x.start).Include("channel").ToList());
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
            if (ModelState.IsValid)
            {
                db.account.Add(newAccount);
                db.SaveChanges();
            }
            ModelState.Clear();
            return RedirectToAction("Login", "Login", new account());
        }

        public ActionResult minSida(account User)
        {
            var Usr = Convert.ToInt32(Session["id"]);
            if (Session["id"] != null)
            {
                var exist = db.favorite.Where(x => x.account_id == Usr).Select(x => x.channel_id).ToList();
                var status = db.channel.Where(x => exist.Contains(x.Id)).Select(x => x.name).Count();
                if (status == 5)
                {
                    Session["status"] = 1;
                }
                else
                {
                    Session["status"] = null;
                }
                ViewBag.favoritelist = db.favorite
                            .Where(x => x.account_id == Usr)
                            .Select(z => z.channel_id).ToList();



                return View(db.program.Include("channel").ToList());
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult adminPanel()
        {
            ViewBag.programList = db.program.Select(f => new SelectListItem { Value = f.id.ToString(), Text = f.name });
            news newnews = new news();
            return View(newnews);
        }


        [HttpPost]
        public ActionResult adminPanel(news newnews)
        {
            
            
                if (ModelState.IsValid)
            {
                    news newly = new news();
                    newly.channel_id = newnews.channel_id;
                    newly.information = newnews.information;
                    newly.director = newnews.director;
                    newly.actors = newnews.actors;
                    
                    db.news.Add(newly);
                    db.SaveChanges();
            }

            ModelState.Clear();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult channelList()
        {
            var Usr = Convert.ToInt32(Session["id"]);
            favorite favorite = new favorite();
            var exist = db.favorite.Where(x => x.account_id == Usr).Select(x => x.channel_id).ToList();

            ViewBag.AddChannels = db.channel.Where(x => !exist.Contains(x.Id)).Select(f => new SelectListItem { Value = f.Id.ToString(), Text = f.name});
           
            return View(favorite);
        }
        [HttpPost]
        public ActionResult channelList(favorite favorite)
        {
            
            var Usr = Convert.ToInt32(Session["id"]);
            
                favorite newly = new favorite();
                newly.channel_id = favorite.channel_id;
                newly.account_id = Usr;
                db.favorite.Add(newly);
                db.SaveChanges();
                 return RedirectToAction("minSida", "Home"); 
        }

        public ActionResult addChannel()
        {
            return View("channelList");
        }

    }
}