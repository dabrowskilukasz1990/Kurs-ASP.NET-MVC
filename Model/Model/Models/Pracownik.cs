using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Model.Models
{
    [Bind(Include = "Imie")]
    public class Pracownik
    {
        public int PracownikId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
    }
}