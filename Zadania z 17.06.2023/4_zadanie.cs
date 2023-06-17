using System;

class Program
{
    static void Main()
    {
        int[] tablica = { 5, 10, 3, 8, 2, 7 }; // Przykładowa tablica

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortujPrzezWstawianie(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WypiszTablice(tablica);
    }

    static void SortujPrzezWstawianie(int[] tablica)
    {
        int n = tablica.Length;

        for (int i = 1; i < n; i++)
        {
            int klucz = tablica[i];
            int j = i - 1;

            while (j >= 0 && tablica[j] > klucz)
            {
                tablica[j + 1] = tablica[j];
                j--;
            }

            tablica[j + 1] = klucz;
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
