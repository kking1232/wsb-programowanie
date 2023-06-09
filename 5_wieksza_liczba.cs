using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź dwie liczby:");

        // Wczytanie pierwszej liczby
        Console.Write("Liczba 1: ");
        int liczba1 = Convert.ToInt32(Console.ReadLine());

        // Wczytanie drugiej liczby
        Console.Write("Liczba 2: ");
        int liczba2 = Convert.ToInt32(Console.ReadLine());

        // Sprawdzenie, która liczba jest większa
        int wiekszaLiczba = (liczba1 > liczba2) ? liczba1 : liczba2;

        // Wyświetlenie wyniku
        Console.WriteLine("Większa liczba: " + wiekszaLiczba);

        Console.ReadLine();
    }
}
