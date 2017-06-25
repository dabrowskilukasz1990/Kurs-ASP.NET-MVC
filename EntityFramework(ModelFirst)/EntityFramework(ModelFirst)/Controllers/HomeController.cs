using EntityFramework_ModelFirst_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFramework_ModelFirst_.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            KontaktyModelContainer db = new KontaktyModelContainer();

            var kontakt1 = db.KontaktySet.FirstOrDefault();


            return View(kontakt1);
        }
    }
}