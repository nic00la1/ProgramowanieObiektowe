﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Klasy
{
    public class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string DataUrodzenia { get; set; }

        public Osoba(string imie, string nazwisko, string dataUrodzenia)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            DataUrodzenia = dataUrodzenia;
        }

        public virtual void WypiszInfo()
        {
            Console.WriteLine("Imie: {0}", Imie);
            Console.WriteLine("Nazwisko: {0}", Nazwisko);
            Console.WriteLine("Data urodzenia: {0}", DataUrodzenia);
        }
    }
}
