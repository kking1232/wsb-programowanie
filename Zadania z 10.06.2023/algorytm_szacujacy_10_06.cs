using System;

class Program
{
    static void Main()
    {
        // Wczytaj wartość x od użytkownika
        Console.WriteLine("Podaj wartość x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        // Wczytaj liczbę wyrazów do uwzględnienia w szeregu Taylora
        Console.WriteLine("Podaj liczbę wyrazów n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Oblicz wartość funkcji e^x
        double result = 0;
        double factorial = 1;

        for (int i = 0; i <= n; i++)
        {
            if (i > 0)
            {
                factorial *= i;
            }

            result += Math.Pow(x, i) / factorial;
        }

        // Wyświetl wynik
        Console.WriteLine("Wartość funkcji e^x: " + result);
    }
}
