using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using SafteyServicePointMVC.Models;

namespace SafteyServicePointMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult About()
        {
            return View();
        }


        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Gaurds()
        {
            return View();
        }


        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(TblUser r)
        {
            using (SafetyDBEntities db = new SafetyDBEntities())
            {
                if (ModelState.IsValid)
                {
                    db.TblUsers.Add(r);
                    db.SaveChanges();
                  //  ViewBag.message("Register Sucess");
                    ModelState.Clear();
                }
            }
            return View(r);
        }
        [HttpPost]
        public ActionResult Login(TblUser r1)
        {
            using (SafetyDBEntities db = new SafetyDBEntities())
            {
                if (ModelState.IsValid)
                {
                    var log = db.TblUsers.Where(a => a.userName.Equals(r1.userName) && a.password.Equals(r1.password)).FirstOrDefault();
                    if (log != null)
                    {
                        return RedirectToAction("Contact");
                    }
                    db.SaveChanges();
                   // ViewBag.message("Login Sucess");
                    ModelState.Clear();
                }
            }
            return View(r1);
        }

    }
}