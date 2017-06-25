using EntityFramework_CodeFirst_.DAL;
using EntityFramework_CodeFirst_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFramework_CodeFirst_.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DodajKontakt(Kontakt kontakt)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", kontakt);
            }
            else
            {
                KontaktyContext db = new KontaktyContext();
                db.Kontakty.Add(kontakt);
                db.SaveChanges();

                return View("Index");
            }

        }
    }
}