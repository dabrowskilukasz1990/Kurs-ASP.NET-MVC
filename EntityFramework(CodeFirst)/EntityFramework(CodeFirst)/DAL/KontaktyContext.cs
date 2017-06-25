using EntityFramework_CodeFirst_.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFramework_CodeFirst_.DAL
{
    public class KontaktyContext : DbContext
    {
        public KontaktyContext() : base("KontaktyConnectionString")
        { }

        public DbSet<Kontakt> Kontakty { get; set; }
        public DbSet<Odpowiedz> Odp { get; set; }

    }

}