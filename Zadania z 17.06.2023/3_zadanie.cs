using System;

class Program
{
    static void Main()
    {
        int[] tablica = { 5, 10, 3, 8, 2, 7 }; // Przykładowa tablica

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortujBabelkowo(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WypiszTablice(tablica);
    }

    static void SortujBabelkowo(int[] tablica)
    {
        int n = tablica.Length;
        bool czyZamiana;

        for (int i = 0; i < n - 1; i++)
        {
            czyZamiana = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (tablica[j] > tablica[j + 1])
                {
                    // Zamiana miejscami elementów
                    int temp = tablica[j];
                    tablica[j] = tablica[j + 1];
                    tablica[j + 1] = temp;

                    czyZamiana = true;
                }
            }

            // Jeśli nie było żadnej zamiany w danej iteracji, tablica jest już posortowana
            if (!czyZamiana)
            {
                break;
            }
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
