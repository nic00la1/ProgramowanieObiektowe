using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Klasy
{
    public class Student : Osoba
    {
        public int Rok;
        public int Grupa;
        public int NrIndeksu;

        public Student(string imie, string nazwisko, string dataUrodzenia, int rok, int grupa, int nrIndeksu) : base(imie, nazwisko, dataUrodzenia)
        {
            Rok = rok;
            Grupa = grupa;
            NrIndeksu = nrIndeksu;
        }


        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Rok: {0}", Rok);
            Console.WriteLine("Grupa: {0}", Grupa);
            Console.WriteLine("Nr indeksu: {0}", NrIndeksu);
        }
    }
}
