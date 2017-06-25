using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WalidacjaDanych.Models;

namespace WalidacjaDanych.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Pracownik pracownik)
        {
            if (!ModelState.IsValid) // Wymuszenie sprawdzania czy zmienna ModelState.IsValid została wypełniona prawidłowo.
            {
                return View("Index", pracownik);
            }
            else
            {
                // Kod który zapisuje nasze dane w bazie
                return View("Index");
            }
        }

    }
}