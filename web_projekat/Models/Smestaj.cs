using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_projekat.Models
{
    public class Smestaj
    {
        public string Naziv { get; set; }
        public SmestajTipovi TipSmestaja { get; set; }
        public string Opis { get; set; }
        public string Adresa { get; set; }
        public string Grad { get; set; }
        public double CenaPoNoci { get; set; }
        public int MaxBrojGostiju { get; set; }
        public string Slika { get; set; }
        public DateTime DatumPostavljanjaOglasa { get; set; }
        public bool Dostupan { get; set; }
        public bool Obrisan { get; set; }//za logicko brisanje
    }
}