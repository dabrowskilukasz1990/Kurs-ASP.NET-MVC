using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SklepInternetowy.Infrastructure
{
    public static class UrlHelpers
    {
        public static string IkonyKategoriiSciezka(this UrlHelper helper, string nazwaIkonyKategorii )
        {
            var ikonyKategoriiFolder = AppConfing.IkonyKategoriFolderWzgledny;
            var sciezka = Path.Combine(ikonyKategoriiFolder, nazwaIkonyKategorii);
            var sciezkaBezwzgledna = helper.Content(sciezka);

           

            return sciezkaBezwzgledna;
        }

        public static string ObrazkiSciezka(this UrlHelper helper, string nazwaObrazka)
        {
            var obrazkiFolder = AppConfing.ObrazkiFolderWzgledny;
            var sciezka = Path.Combine(obrazkiFolder, nazwaObrazka);
            var sciezkaBezwzgledna = helper.Content(sciezka);

           

            return sciezkaBezwzgledna;
        }
    }
}