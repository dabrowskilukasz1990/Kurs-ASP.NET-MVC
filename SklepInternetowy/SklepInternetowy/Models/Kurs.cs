﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SklepInternetowy.Models
{
    public class Kurs
    {
        // TO ZOSTAŁO STWORZONE JAKO PIERWSZE ZARAZ PO HOMECONTROLLER
        public int KursId { get; set; }
        public int KategoriaId { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwę kursu")]
        [StringLength(100)]
        public string TytulKursu { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwę autora")]
        [StringLength(100)]
        public string AutorKursu { get; set; }
        public DateTime DataDodania { get; set; }
        [StringLength(100)]
        public string NazwaPlikuObrazka { get; set; }
        public string OpisKursu { get; set; }
        public decimal CenaKursu { get; set; }
        public bool Bestseller { get; set; }
        public bool Ukryty { get; set; }
        public string OpisSkrocony { get; set; } //DODANIE POLA ABY POKAZAć JAK DZIAŁAJA MIGRACJE
        //Usuwamy pole public string Test { get; set; } //DODANIE KOLEJNEGO POLA W CELACH TESTOWYCH

        public virtual Kategoria Kategoria { get; set; }


    }
}