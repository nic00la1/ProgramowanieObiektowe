using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Klasy
{
    public class Piłkarz : Osoba
    {
        private string pozycja;
        private string klub;
        private int liczbaGoli = 0;

        public Piłkarz(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub) : base(imie, nazwisko,dataUrodzenia)
        {
            this.pozycja = pozycja;
            this.klub = klub;
        }

        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Pozycja: {0}", pozycja);
            Console.WriteLine("Klub: {0}", klub);
            Console.WriteLine("Liczba goli: {0}", liczbaGoli);
        }

        public void StrzelGola()
        {
            liczbaGoli++;
        }
    }
}
