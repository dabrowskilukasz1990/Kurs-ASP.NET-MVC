using EntityFramework_DateBaseFirst_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFramework_DateBaseFirst_.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            BazaModelFirstEntities db = new BazaModelFirstEntities();
            var kontakty = db.Kontakty;


            return View(kontakty);
        }
    }
}