using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Wersja 1 - Losowanie i sprawdzanie:");
        LosujINapiszParzysteV1(n);

        Console.WriteLine("\nWersja 2 - Losowanie liczby parzystej:");
        LosujINapiszParzysteV2(n);
    }

    static void LosujINapiszParzysteV1(int n)
    {
        Random random = new Random();
        int licznikLosowan = 0;
        int liczbaParzysta;
        bool czyParzysta;

        for (int i = 0; i < n; i++)
        {
            do
            {
                liczbaParzysta = random.Next(-8, 9);
                czyParzysta = liczbaParzysta % 2 == 0;
                licznikLosowan++;
            }
            while (!czyParzysta);

            Console.Write(liczbaParzysta);

            if (i < n - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine("\nLiczba wykonanych losowań: " + licznikLosowan);
    }

    static void LosujINapiszParzysteV2(int n)
    {
        Random random = new Random();
        int licznikLosowan = 0;
        int liczbaParzysta;

        for (int i = 0; i < n; i++)
        {
            liczbaParzysta = random.Next(-4, 5) * 2;
            licznikLosowan++;

            Console.Write(liczbaParzysta);

            if (i < n - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine("\nLiczba wykonanych losowań: " + licznikLosowan);
    }
}
