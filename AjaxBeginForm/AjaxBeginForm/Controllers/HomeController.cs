using AjaxBeginForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxBeginForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(Album album)
        {
            //Zwykły string
            //return Content(string.Format("Tytuł : {0}, Autor : {1}, Cena : {2}", album.Tytul, album.Autor, album.Cena));

            //Za pomocą formatu Json
            return Json(album);
        }

    }
}