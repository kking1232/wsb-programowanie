using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź trzy liczby:");

        // Wczytanie pierwszej liczby
        Console.Write("Liczba 1: ");
        double liczba1 = Convert.ToDouble(Console.ReadLine());

        // Wczytanie drugiej liczby
        Console.Write("Liczba 2: ");
        double liczba2 = Convert.ToDouble(Console.ReadLine());

        // Wczytanie trzeciej liczby
        Console.Write("Liczba 3: ");
        double liczba3 = Convert.ToDouble(Console.ReadLine());

        // Obliczenie średniej arytmetycznej
        double srednia = (liczba1 + liczba2 + liczba3) / 3;

        // Wyświetlenie wyniku
        Console.WriteLine("Średnia arytmetyczna: " + srednia);

        Console.ReadLine();
    }
}
