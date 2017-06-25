using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFramework_CodeFirst_.Models
{
    public class Odpowiedz
    {
        public int OdpowiedzId { get; set; }
        public string Odp { get; set; }
        public string Pytanie { get; set; }
    }
}