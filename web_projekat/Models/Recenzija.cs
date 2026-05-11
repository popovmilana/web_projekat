using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_projekat.Models
{
    public class Recenzija
    {
        public string SmestajNaziv { get; set; }
        public string RecenzentKorisnickoIme { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public int Ocena { get; set; }//1-5
        public string Slika { get; set; } //opciono
        public RecenzijaStatus Status { get; set; }
    }
}