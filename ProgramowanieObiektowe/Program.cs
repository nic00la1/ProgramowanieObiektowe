using ConsoleTables;
using ProgramowanieObiektowe.Klasy;

class Program
{
    public static void Main(string[] args)
    {
        Osoba osoba = new Osoba("Jan", "Kowalski", "14.07.1997");
        Osoba student = new Student("Krystian", "Nowak", "21.02.2004", 2, 5, 252355);
        Osoba piłkarz = new Piłkarz("Robert", "Lewandowski", "21.08.1988", "napastnik", "FC Barcelona");

        var table = new ConsoleTable("Imię", "Nazwisko", "Data Urodzenia", "Dodatkowe Informacje");

        Console.WriteLine("Dane przed zmianami");

        table.AddRow(osoba.Imie, osoba.Nazwisko, osoba.DataUrodzenia, "Osoba")
             .AddRow(student.Imie, student.Nazwisko, student.DataUrodzenia, $"Student: Rok: {((Student)student).Rok}, Grupa: {((Student)student).Grupa}, Nr Indeksu: {((Student)student).NrIndeksu}")
             .AddRow(piłkarz.Imie, piłkarz.Nazwisko, piłkarz.DataUrodzenia, $"Piłkarz: Pozycja: {((Piłkarz)piłkarz).Pozycja}, Klub: {((Piłkarz)piłkarz).Klub}");
        table.Write();

        Student student2 = new Student("Krzysztof", "Kaczyński", "15.08.2003", 2, 1, 212542);
        Piłkarz piłkarz2 = new Piłkarz("Wojciech", "Szczęsny", "18.04.1990", "bramkarz", "FC Barcelona");

        Console.WriteLine("Nowe jednostki");

        table = new ConsoleTable("Imię", "Nazwisko", "Data Urodzenia", "Dodatkowe Informacje");
        table.AddRow(student2.Imie, student2.Nazwisko, student2.DataUrodzenia, $"Student: Rok: {student2.Rok}, Grupa: {student2.Grupa}, Nr Indeksu: {student2.NrIndeksu}")
             .AddRow(piłkarz2.Imie, piłkarz2.Nazwisko, piłkarz2.DataUrodzenia, $"Piłkarz: Pozycja: {piłkarz2.Pozycja}, Klub: {piłkarz2.Klub}");
        table.Write();

        ((Piłkarz)piłkarz).StrzelGola();
        piłkarz2.StrzelGola();
        piłkarz2.StrzelGola();

        Console.WriteLine("Dane po strzeleniu gola");

        table = new ConsoleTable("Imię", "Nazwisko", "Data Urodzenia", "Dodatkowe Informacje");
        table.AddRow(piłkarz.Imie, piłkarz.Nazwisko, piłkarz.DataUrodzenia, $"Piłkarz: Pozycja: {((Piłkarz)piłkarz).Pozycja}, Klub: {((Piłkarz)piłkarz).Klub}, Gole: {((Piłkarz)piłkarz).LiczbaGoli}")
             .AddRow(piłkarz2.Imie, piłkarz2.Nazwisko, piłkarz2.DataUrodzenia, $"Piłkarz: Pozycja: {piłkarz2.Pozycja}, Klub: {piłkarz2.Klub}, Gole: {piłkarz2.LiczbaGoli}");

        table.Write();

        Console.ReadKey();
    }
}
