using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_projekat.Models
{
    public class Rezervacija
    {
        public string SmestajNaziv { get; set; }
        public string GostKorisnickoIme { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumKraja { get; set; }
        public int BrojGostiju { get; set; }
         public double UkupnaCena { get; set; }
         public RezervacijaStatus Status { get; set; }
    }
}