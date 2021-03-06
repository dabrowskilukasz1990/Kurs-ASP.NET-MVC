﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MechanizmRoutingu
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "SamochodSzczegoly",
                url: "Samochod-{id}",
                defaults: new { controller = "Sklep", action = "Szczegoly"}
            );

            routes.MapRoute(
                name: "SamochodLista",
                url: "model/{nazwa}",
                defaults: new { controller = "Sklep", action = "Lista"},
                constraints: new { nazwa= @"[\w]+"} //ograniczenia
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
