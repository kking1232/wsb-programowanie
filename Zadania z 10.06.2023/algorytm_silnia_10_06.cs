using System;

class Program
{
    static void Main()
    {
        // Wczytaj liczbę x od użytkownika
        Console.WriteLine("Podaj liczbę x: ");
        int x = Convert.ToInt32(Console.ReadLine());

        int n = 0;
        int factorial = 1;

        // Szukaj liczby n, dla której n! == x
        while (factorial <= x)
        {
            if (factorial == x)
            {
                Console.WriteLine("Liczba {0} jest silnią liczby {1}.", x, n);
                return;
            }

            n++;
            factorial *= n;
        }

        Console.WriteLine("Liczba {0} nie jest silnią żadnej liczby.", x);
    }
}
