using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Klasy
{
    public class Piłkarz : Osoba
    {
        public string Pozycja;
        public string Klub;
        public int LiczbaGoli = 0;

        public Piłkarz(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub) : base(imie, nazwisko,dataUrodzenia)
        {
            Pozycja = pozycja;
            Klub = klub;
        }


        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Pozycja: {0}", Pozycja);
            Console.WriteLine("Klub: {0}", Klub);
            Console.WriteLine("Liczba goli: {0}", LiczbaGoli);
        }

        public void StrzelGola()
        {
            LiczbaGoli++;
        }
    }
}
