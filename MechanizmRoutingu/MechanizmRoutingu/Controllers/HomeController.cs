using MechanizmRoutingu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MechanizmRoutingu.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            List<Contacts> con = new List<Contacts>();

            con.Add(new Contacts { Name = "Lukasz", LastName = "Dabrowski", Street = "Owsiana", City = "Gdynia" });
            con.Add(new Contacts { Name = "Tomasz", LastName = "Dabrowski", Street = "Gniewska", City = "Gdynia" });
            con.Add(new Contacts { Name = "Dorota", LastName = "Dabrowski", Street = "Gniewska", City = "Gdynia" });

            ViewBag.Contact = con;

            return View();
        }
    }
}