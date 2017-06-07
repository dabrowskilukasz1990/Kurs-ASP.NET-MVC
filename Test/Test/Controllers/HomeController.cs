using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {

            List<Kontakty> con = new List<Kontakty>();

            con.Add(new Kontakty { Imie = "Lukasz", Nazwisko = "Dabrowski", Ulica = "Owsiana", Miasto = "Gdynia" });
            con.Add(new Kontakty { Imie = "Tomasz", Nazwisko = "Dabrowski", Ulica = "Gniewska", Miasto = "Gdynia" });
            con.Add(new Kontakty { Imie = "Dorota", Nazwisko = "Dabrowski", Ulica = "Gniewska", Miasto = "Gdynia" });

            ViewBag.Kontakt = con;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}