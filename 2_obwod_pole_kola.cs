using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź pole koła:");

        // Wczytanie pola koła
        Console.Write("Pole koła: ");
        double pole = Convert.ToDouble(Console.ReadLine());

        // Obliczenie promienia koła
        double promien = Math.Sqrt(pole / Math.PI);

        // Obliczenie obwodu koła
        double obwod = 2 * Math.PI * promien;

        // Wyświetlenie wyniku
        Console.WriteLine("Obwód koła: " + obwod);

        Console.ReadLine();
    }
}
