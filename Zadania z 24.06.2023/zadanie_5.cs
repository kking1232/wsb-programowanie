using System;

class Program
{
    static void Main()
    {
        int[,] kwadratMagiczny = {
            { 2, 7, 6 },
            { 9, 5, 1 },
            { 4, 3, 8 }
        };

        int[,] kwadratNieUnikatowy = {
            { 1, 1, 1 },
            { 1, 1, 1 },
            { 1, 1, 1 }
        };

        int[,] kwadratNieSuma = {
            { 2, 7, 6 },
            { 9, 5, 1 },
            { 4, 3, 9 }
        };

        Console.WriteLine("Wybierz kwadrat do sprawdzenia:");
        Console.WriteLine("1. Kwadrat magiczny");
        Console.WriteLine("2. Kwadrat nieunikatowy");
        Console.WriteLine("3. Kwadrat niesuma");
        Console.Write("Wybór: ");

        int wybor;
        while (!int.TryParse(Console.ReadLine(), out wybor) || wybor < 1 || wybor > 3)
        {
            Console.WriteLine("Nieprawidłowy wybór. Wprowadź liczbę od 1 do 3.");
            Console.Write("Wybór: ");
        }

        int[,] tablica = null;

        if (wybor == 1)
        {
            tablica = kwadratMagiczny;
        }
        else if (wybor == 2)
        {
            tablica = kwadratNieUnikatowy;
        }
        else if (wybor == 3)
        {
            tablica = kwadratNieSuma;
        }

        if (tablica != null)
        {
            bool jestKwadratemMagicznym = SprawdzCzyKwadratMagiczny(tablica);

            if (jestKwadratemMagicznym)
            {
                Console.WriteLine("Podany kwadrat jest kwadratem magicznym.");
            }
            else
            {
                Console.WriteLine("Podany kwadrat nie jest kwadratem magicznym.");
            }
        }
        else
        {
            Console.WriteLine("Błędny wybór.");
        }
    }

    static bool SprawdzCzyKwadratMagiczny(int[,] tablica)
    {
        int rozmiar = tablica.GetLength(0);

        // Sprawdzenie sum na przekątnych
        int sumaGlowna = 0;
        int sumaBoczna = 0;
        for (int i = 0; i < rozmiar; i++)
        {
            sumaGlowna += tablica[i, i];
            sumaBoczna += tablica[i, rozmiar - 1 - i];
        }
        if (sumaGlowna != sumaBoczna)
        {
            return false;
        }

        // Sprawdzenie sum w wierszach i kolumnach
        for (int i = 0; i < rozmiar; i++)
        {
            int sumaWiersza = 0;
            int sumaKolumny = 0;
            for (int j = 0; j < rozmiar; j++)
            {
                sumaWiersza += tablica[i, j];
                sumaKolumny += tablica[j, i];
            }
            if (sumaWiersza != sumaGlowna || sumaKolumny != sumaGlowna)
            {
                return false;
            }
        }

        return true;
    }
}