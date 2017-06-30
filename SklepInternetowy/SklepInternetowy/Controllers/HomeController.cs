using SklepInternetowy.DAL;
using SklepInternetowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SklepInternetowy.Controllers
{
    public class HomeController : Controller
    {
        private KursyContext db = new KursyContext(); //Deklaracja Contextu

        // GET: Home
        public ActionResult Index()
        {
            var listaKategorii = db.Kategorie.ToList();

            return View();
        }

        public ActionResult StronyStatyczne(string nazwa) //Definiowanie StronyStatyczne, tam gdzie "nazwa" będzie podstrona.
        {
            return View(nazwa);
        }
    }
}