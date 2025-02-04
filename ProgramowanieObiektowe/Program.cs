using ProgramowanieObiektowe.Klasy;

class Program
{
    public static void Main(string[] args)
    {
        Osoba osoba = new Osoba("Jan", "Kowalski", "14.07.1997");
        Osoba student = new Student("Krystian", "Nowak", "21.02.2004", 2, 5, 252355);
        Osoba piłkarz = new Piłkarz("Robert", "Lewandowski", "21.08.1988", "napastnik", "FC Barcelona");

        osoba.WypiszInfo();
        student.WypiszInfo();
        piłkarz.WypiszInfo();

        Student student2 = new Student("Jan", "Kaczyński", "15.08.2003", 2, 1, 212542);
        Piłkarz piłkarz2 = new Piłkarz("Wojciech", "Szczęsny", "18.04.1990", "bramkarz", "FC Barcelona");

        student2.WypiszInfo();
        piłkarz2.WypiszInfo();

        ((Piłkarz)piłkarz).StrzelGola();
        piłkarz2.StrzelGola();
        piłkarz2.StrzelGola();

        piłkarz.WypiszInfo();
        piłkarz2.WypiszInfo();

        Console.ReadKey();
    }
}