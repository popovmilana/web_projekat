using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_projekat.Models
{
    public class Korisnik
    {
        public string KorisnickoIme { get; set; }//jedinstveno
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Pol { get; set; }
        public KorisnikTipovi TipKorisnika { get; set; }

        public bool Obrisan { get; set; }//za logicko brisanje
    }
}