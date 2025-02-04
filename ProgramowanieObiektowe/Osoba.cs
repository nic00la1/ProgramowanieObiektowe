using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe
{
    public class Osoba
    {
        protected string Imie { get; set; }
        protected string Nazwisko { get; set; }
        protected string DataUrodzenia { get; set; }

        public Osoba(string imie, string nazwisko, string dataUrodzenia)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            DataUrodzenia = dataUrodzenia;
        }

        public void WypiszInfo()
        {

        }
    }
}
