using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź trzy boki trójkąta:");

        // Wczytanie pierwszego boku
        Console.Write("Bok 1: ");
        double bok1 = Convert.ToDouble(Console.ReadLine());

        // Wczytanie drugiego boku
        Console.Write("Bok 2: ");
        double bok2 = Convert.ToDouble(Console.ReadLine());

        // Wczytanie trzeciego boku
        Console.Write("Bok 3: ");
        double bok3 = Convert.ToDouble(Console.ReadLine());

        // Sprawdzenie warunku trójkąta równobocznego
        bool czyTrojkatRownoboczny = (bok1 == bok2) && (bok2 == bok3);

        // Wyświetlenie wyniku
        if (czyTrojkatRownoboczny)
        {
            Console.WriteLine("Podane boki tworzą trójkąt równoboczny.");
        }
        else
        {
            Console.WriteLine("Podane boki nie tworzą trójkąta równobocznego.");
        }

        Console.ReadLine();
    }
}
