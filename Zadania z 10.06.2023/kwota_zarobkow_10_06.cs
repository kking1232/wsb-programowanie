using System;

class Program
{
    static void Main()
    {
        // Wczytaj dane wejściowe od użytkownika
        Console.WriteLine("Podaj kwotę początkową na koncie: ");
        decimal kwotaPoczatkowa = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Podaj oprocentowanie konta w skali roku (%): ");
        decimal oprocentowanie = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Podaj liczbę miesięcy oszczędzania: ");
        int liczbaMiesiecy = Convert.ToInt32(Console.ReadLine());

        // Oblicz końcową kwotę na koncie oszczędnościowym
        decimal oprocentowanieMiesieczne = 1 + (oprocentowanie / 12 / 100);
        decimal koncowaKwota = kwotaPoczatkowa * (decimal)Math.Pow((double)oprocentowanieMiesieczne, liczbaMiesiecy);

        // Oblicz podatek Belki
        decimal podatekBelki = koncowaKwota * 0.19m;

        // Oblicz kwotę zarobioną po odjęciu podatku Belki
        decimal zarobek = koncowaKwota - podatekBelki;

        // Wyświetl wynik
        Console.WriteLine("Kwota zarobiona na koncie: " + zarobek.ToString("C"));
    }
}
