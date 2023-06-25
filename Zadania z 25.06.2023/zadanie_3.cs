using System;

public enum KlasaRzadkosci
{
    Powszechny,
    Rzadki,
    Unikalny,
    Epicki
}

public enum TypPrzedmiotu
{
    Bron,
    Zbroja,
    Amulet,
    Pierscien,
    Helm,
    Tarcza,
    Buty
}

public struct Przedmiot
{
    public float Waga;
    public int Wartosc;
    public KlasaRzadkosci Rzadkosc;
    public TypPrzedmiotu Typ;
    public string Nazwa;

    public Przedmiot(float waga, int wartosc, KlasaRzadkosci rzadkosc, TypPrzedmiotu typ, string nazwa)
    {
        Waga = waga;
        Wartosc = wartosc;
        Rzadkosc = rzadkosc;
        Typ = typ;
        Nazwa = nazwa;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine($"Nazwa: {Nazwa}");
        Console.WriteLine($"Typ: {Typ}");
        Console.WriteLine($"Rzadkosc: {Rzadkosc}");
        Console.WriteLine($"Waga: {Waga}");
        Console.WriteLine($"Wartosc: {Wartosc} sztuk złota");
        Console.WriteLine();
    }
}

public class LosowaniePrzedmiotu
{
    private static Random random = new Random();

    public static Nullable<Przedmiot> WylosujPrzedmiot(Przedmiot[] przedmioty)
    {
        float sumaWag = 0;
        foreach (var przedmiot in przedmioty)
        {
            sumaWag += przedmiot.Waga;
        }

        float losowaLiczba = (float)random.NextDouble() * sumaWag;

        float aktualnaWaga = 0;
        foreach (var przedmiot in przedmioty)
        {
            aktualnaWaga += przedmiot.Waga;
            if (losowaLiczba < aktualnaWaga)
            {
                return przedmiot;
            }
        }

        return null;
    }

    public static void Main()
    {
        Przedmiot[] przedmioty = new Przedmiot[]
        {
            new Przedmiot(1.5f, 10, KlasaRzadkosci.Powszechny, TypPrzedmiotu.Bron, "Miecz"),
            new Przedmiot(2.0f, 20, KlasaRzadkosci.Rzadki, TypPrzedmiotu.Zbroja, "Zbroja płytowa"),
            new Przedmiot(0.8f, 15, KlasaRzadkosci.Rzadki, TypPrzedmiotu.Amulet, "Amulet mocy"),
            new Przedmiot(0.5f, 5, KlasaRzadkosci.Powszechny, TypPrzedmiotu.Pierscien, "Pierścień zdrowia"),
            new Przedmiot(0.3f, 50, KlasaRzadkosci.Epicki, TypPrzedmiotu.Helm, "Helm nieśmiertelności"),
            new Przedmiot(1.2f, 30, KlasaRzadkosci.Unikalny, TypPrzedmiotu.Tarcza, "Tarcza obrony"),
            new Przedmiot(0.6f, 12, KlasaRzadkosci.Powszechny, TypPrzedmiotu.Buty, "Buty zwinności")
        };

        Nullable<Przedmiot> wylosowanyPrzedmiot = WylosujPrzedmiot(przedmioty);
        if (wylosowanyPrzedmiot.HasValue)
        {
            Console.WriteLine("Wylosowany przedmiot:");
            wylosowanyPrzedmiot.Value.WyswietlInformacje();
        }
        else
        {
            Console.WriteLine("Brak przedmiotów do wylosowania.");
        }
    }
}
