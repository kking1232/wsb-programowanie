using System;

public enum Plec
{
    Mezczyzna,
    Kobieta
}

public struct Student
{
    public string Nazwisko;
    public int NrAlbumu;
    public float Ocena;
    public Plec Plec;

    public void WypelnijStudenta(string nazwisko, int nrAlbumu, float ocena, Plec plec)
    {
        Nazwisko = nazwisko;
        NrAlbumu = nrAlbumu;
        Ocena = Math.Max(2.0f, Math.Min(5.0f, ocena));
        Plec = plec;
    }

    public static float Srednia(Student[] grupa)
    {
        float sumaOcen = 0;
        foreach (var student in grupa)
        {
            sumaOcen += student.Ocena;
        }

        return sumaOcen / grupa.Length;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine($"Nazwisko: {Nazwisko}, Nr albumu: {NrAlbumu}, Ocena: {Ocena}, Płeć: {Plec}");
    }
}

public class Program
{
    public static void Main()
    {
        Student[] grupa = new Student[5];

        grupa[0].WypelnijStudenta("Kowalski", 123456, 4.5f, Plec.Mezczyzna);
        grupa[1].WypelnijStudenta("Nowak", 654321, 3.8f, Plec.Kobieta);
        grupa[2].WypelnijStudenta("Smith", 987654, 2.5f, Plec.Mezczyzna);
        grupa[3].WypelnijStudenta("Johnson", 234567, 4.2f, Plec.Kobieta);
        grupa[4].WypelnijStudenta("Lee", 876543, 3.6f, Plec.Mezczyzna);

        Console.WriteLine("Grupa studentow:");
        foreach (var student in grupa)
        {
            student.WyswietlInformacje();
        }

        float sredniaOcen = Student.Srednia(grupa);
        Console.WriteLine($"Średnia ocen w grupie: {sredniaOcen}");
    }
}
