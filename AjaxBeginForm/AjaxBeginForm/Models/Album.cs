using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxBeginForm.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public double Cena { get; set; }
    }
}