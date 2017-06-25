using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Model.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Pracownik pracownik = new Pracownik()
            {
                PracownikId = 10,
                Imie = "Marcin",
                Nazwisko = "Kowalski",
                Miasto = "Gdynia",
                Ulica = "Gniewska 21/109"
            };
            return View(pracownik);
        }

        public ActionResult Edit()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Imie")/* - Zabezpiecznie przeciwko hakerom pokazuje tylko*/]Pracownik pracownik)  //Model binding
        {

            return Content(string.Format("Pracownik ID : {0}, Imie : {1}, Nazwisko : {2}, Miasto : {3}, Ulica : {4}", pracownik.PracownikId, pracownik.Imie, pracownik.Nazwisko, pracownik.Miasto, pracownik.Ulica));
        }
        //[HttpPost]
        //public ActionResult Edit(int?/* - może być puste pole*/ PracownikId, string Imie, string Nazwisko, string Miasto, string Ulica)/*"Mickiewicza 666" - wartość domyślna gdy nie zostanie wpisana Ulica w formularzu*/ // Automatyczny model binding
        //{

        //    return Content(string.Format("Pracownik ID : {0}, Imie : {1}, Nazwisko : {2}, Miasto : {3}, Ulica : {4}", PracownikId, Imie, Nazwisko, Miasto, Ulica));
        //}

    }
}
