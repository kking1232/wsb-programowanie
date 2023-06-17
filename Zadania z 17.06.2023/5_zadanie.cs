using System;

class Program
{
    static void Main()
    {
        int[] tablica = { 5, 10, 3, 8, 2, 7 }; // Przykładowa tablica

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortujPrzezWybieranie(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WypiszTablice(tablica);
    }

    static void SortujPrzezWybieranie(int[] tablica)
    {
        int n = tablica.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int indeksMinimum = i;

            for (int j = i + 1; j < n; j++)
            {
                if (tablica[j] < tablica[indeksMinimum])
                {
                    indeksMinimum = j;
                }
            }

            // Zamiana miejscami elementów
            int temp = tablica[i];
            tablica[i] = tablica[indeksMinimum];
            tablica[indeksMinimum] = temp;
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
