using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź współrzędne punktu P (x, y):");

        // Wczytanie współrzędnej x
        Console.Write("x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        // Wczytanie współrzędnej y
        Console.Write("y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wprowadź promień koła:");
        double r = Convert.ToDouble(Console.ReadLine());

        // Obliczenie odległości punktu P od środka O
        double odleglosc = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

        // Sprawdzenie warunku czy punkt leży w obrębie koła
        if (odleglosc <= r)
        {
            Console.WriteLine("Punkt P leży w obrębie koła.");
        }
        else
        {
            Console.WriteLine("Punkt P nie leży w obrębie koła.");
        }

        Console.ReadLine();
    }
}
