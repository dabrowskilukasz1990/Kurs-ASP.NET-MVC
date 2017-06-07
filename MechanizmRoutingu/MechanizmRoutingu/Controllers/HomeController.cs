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
        public string Index()
        {
            var wynik = RouteTable;
        }
    }
}