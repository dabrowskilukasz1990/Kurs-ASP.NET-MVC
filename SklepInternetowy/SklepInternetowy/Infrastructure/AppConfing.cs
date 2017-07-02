using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SklepInternetowy.Infrastructure
{
    public class AppConfing //Klasa do dostawania się do Web.config
    {
        private static string _ikonyKategoriFolderWzgledny = ConfigurationManager.AppSettings["IkonyKategoriiFolder"];

        public static string IkonyKategoriFolderWzgledny
        {
            get
            {
                return _ikonyKategoriFolderWzgledny;
            }
        }

        private static string _obrazkiFolderWzgledny = ConfigurationManager.AppSettings["ObrazkiFolder"];

        public static string ObrazkiFolderWzgledny
        {
            get
            {
                return _obrazkiFolderWzgledny;
            }
        }

    }
}