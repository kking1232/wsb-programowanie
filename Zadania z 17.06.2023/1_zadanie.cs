using System;

class Program
{
    static void Main()
    {
        int[] tablica = GenerujTablice(10); // Generowanie tablicy o rozmiarze 10

        Console.WriteLine("Tablica przed odwróceniem:");
        WypiszTablice(tablica);

        OdwrocTablice(tablica);

        Console.WriteLine("Tablica po odwróceniu:");
        WypiszTablice(tablica);
    }

    static int[] GenerujTablice(int rozmiar)
    {
        Random rand = new Random();
        int[] tablica = new int[rozmiar];

        for (int i = 0; i < rozmiar; i++)
        {
            tablica[i] = rand.Next(100); // Wypełnianie tablicy losowymi wartościami od 0 do 99
        }

        return tablica;
    }

    static void OdwrocTablice(int[] tablica)
    {
        int lewy = 0;
        int prawy = tablica.Length - 1;

        while (lewy < prawy)
        {
            // Zamiana miejscami elementów na krańcach tablicy
            int temp = tablica[lewy];
            tablica[lewy] = tablica[prawy];
            tablica[prawy] = temp;

            lewy++;
            prawy--;
        }
    }

    static void WypiszTablice(int[] tablica)
    {
        for (int i = 0; i < tablica.Length; i++)
        {
            Console.Write(tablica[i] + " ");
        }
        Console.WriteLine();
    }
}
