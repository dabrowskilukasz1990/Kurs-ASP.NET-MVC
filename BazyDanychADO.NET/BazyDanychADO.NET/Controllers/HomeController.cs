using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BazyDanychADO.NET.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;" //Definiowanie połaczenia z bazą danych "BazaADO.NET.mdf". ConnectionStringa można pobrać z bazy danych w oknie Properties.
                + "AttachDbFilename = \"F:\\Microsoft Visual Studio 2015\\Git\\Kurs ASP.NET MVC\\BazyDanychADO.NET\\BazyDanychADO.NET\\App_Data\\BazaADO.NET.mdf\"; Integrated Security = True";

            string query = "Select Nazwa, Email from dbo.KontaktyADO where id=@id"; //Zapytanie do bazy danych. (Wybierz Nazwa, Email z tabeli KontaktyADO gdzie id= id które ustalilimy w parametrze)"

            int id = 2;

            using (SqlConnection connection = new SqlConnection(connectionString)) //Utworzenie połączenia do którego wcześniej utworzyliśmy connectionString.
            {
                SqlCommand command = new SqlCommand(query, connection); //Komenda która będziemy chcieli wykonać na bazie danych.
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader(); //Wykonanie połącznie. Wynik jest w zmiennej reader.
                reader.Read();

                var nazwa = reader[0];
                var email = reader[1];


                ViewBag.Nazwa = nazwa;
                ViewBag.Email = email;

            }


                return View();
        }
    }
}