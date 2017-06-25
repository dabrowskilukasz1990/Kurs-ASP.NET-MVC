using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFramework_CodeFirst_.Models
{
    public class Kontakt
    {
        public int KontaktId { get; set; }
        [Required(ErrorMessage = "Wymagane podanie imienia")]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Wymagane podanie nazwiska")]
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public string NowePole { get; set; }
        public string Pytanie { get; set; }
    }
}