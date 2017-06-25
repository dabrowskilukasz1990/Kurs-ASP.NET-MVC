using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WalidacjaDanych.Models
{
    public class Pracownik
    {
        [ScaffoldColumn(false)] //Ignorowanie kolumny w formularzu.
        public int PracownikId { get; set; }

        [Display(Name = "Imię pracownika: ")] //Będzie wyświetlane obok kolumny.
        [Required(ErrorMessage = "Musisz podać imię")] //Nie może zostać pustę pole i wyświetla informacje gdy zostanie puste.
        [StringLength(30)] // Maksymalna długość pola imię to 30 znaków
        public string Imie { get; set; }

        [Display(Name = "Wiek pracownika: ")]
        [Required(ErrorMessage = "Musisz wprowadzić wiek pracownika")]
        [Range(10, 40)] // Między 10 a 40. W tym przypadku chodzi o wiek między 10 lat a 40 lat.
        public int Wiek { get; set; }

        [Display(Name = "Adres Email pracownika: ")]
        [Required(ErrorMessage = "Musisz podać adres e-mail pracownika")]
        [EmailAddress] // Format ogólny adresu emial. Sprawdza czy w pole został wpisany emial
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Nr Telefonu pracownika: ")]
        [RegularExpression(@"[0-9]{9}" /*9 cyfr wszystkie między 0-9*/, ErrorMessage = "Musisz wpisać poprawny numer telefonu w formacie 123456789")]
        public string NrTelefonu { get; set; }

        [Display(Name = "Pytanie do szefa")]
        [DataType(DataType.MultilineText)] //Pole do wpisania, będzie polem w którym będzie mozna wpisać coś w wielu liniach.
        public string Pytanie { get; set; }

        
    }
}