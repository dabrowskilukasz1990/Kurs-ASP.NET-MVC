using SklepInternetowy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SklepInternetowy.DAL
{
    // TO ZOSTALO STWORZONE JAKO PIATE DEFINIUJEMY TUTAJ TABELE DO BAZY DANYCH Z NASZEGO MODELU
    public class KursyContext : DbContext
    {
        public KursyContext() : base("KursyContext") //Konstruktor który tworzy bazę danych, tabele itd.
        {

        }

        //Wywołanie metody KursyInitializer.cs, aby nasze dane testowe pojawiły się w bazie danych
        static KursyContext()
        {
            Database.SetInitializer<KursyContext>(new KursyInitializer());
        }

        public DbSet<Kurs> Kursy { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Zamowienie> Zamowienia { get; set; }
        public DbSet<PozycjaZamowienia> PozycjeZamowienia { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // using System.Data.Entity.ModelConfiguration.Conventions;
            // Wyłącza konwencję, która automatycznie tworzy liczbę mnogą dla nazw tabel w bazie danych
            // Zamiast Kategorie zostałaby stworzona tabela o nazwie Kategories
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}