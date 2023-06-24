using System;

class Program
{
    static void Main()
    {
        int rozmiar;

        do
        {
            Console.Write("Podaj rozmiar tablicy (liczba wierszy i kolumn): ");
        }
        while (!int.TryParse(Console.ReadLine(), out rozmiar) || rozmiar <= 0);

        int[,] tablica = new int[rozmiar, rozmiar];

        for (int i = 0; i < rozmiar; i++)
        {
            if (i % 2 == 0)
            {
                // Wiersze parzyste - rosnąco
                for (int j = 0; j < rozmiar; j++)
                {
                    tablica[i, j] = i * rozmiar + j + 1;
                }
            }
            else
            {
                // Wiersze nieparzyste - malejąco
                for (int j = 0; j < rozmiar; j++)
                {
                    tablica[i, j] = (i + 1) * rozmiar - j;
                }
            }
        }

        // Wypisanie tablicy na ekranie
        for (int i = 0; i < rozmiar; i++)
        {
            for (int j = 0; j < rozmiar; j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
