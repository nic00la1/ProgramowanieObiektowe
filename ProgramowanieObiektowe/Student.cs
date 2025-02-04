using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe
{
    public class Student : Osoba
    {
        private int rok;
        private int grupa;
        private int nrIndeksu;

        public Student(string imie, string nazwisko, string dataUrodzenia, int rok, int grupa, int nrIndeksu) : base(imie, nazwisko, dataUrodzenia)
        {
            this.rok = rok;
            this.grupa = grupa;
            this.nrIndeksu = nrIndeksu;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Imie: {0}", Imie);
            Console.WriteLine("Nazwisko: {0}", Nazwisko);
            Console.WriteLine("Data urodzenia: {0}", DataUrodzenia);
            Console.WriteLine("Rok: {0}", rok);
            Console.WriteLine("Grupa: {0}", grupa);
            Console.WriteLine("Nr indeksu: {0}", nrIndeksu);
        }
    }
}
