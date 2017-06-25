using HtmlHelpers2_DynamiczneHelpery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpers2_DynamiczneHelpery.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var helpers = new Helpers()
            {
                DateTime = new DateTime(2017, 6, 19),
                Bool = true,
                String = "Asp.NET",
                Decimal = 164123123.544m,
                Int = 666

            };
            return View(helpers);
        }
    }
}