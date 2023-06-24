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

        int num = 1;
        int startRow = 0;
        int endRow = rozmiar - 1;
        int startCol = 0;
        int endCol = rozmiar - 1;

        while (startRow <= endRow && startCol <= endCol)
        {
            // Wypełnianie wiersza od lewej do prawej
            for (int i = startCol; i <= endCol; i++)
            {
                tablica[startRow, i] = num++;
            }
            startRow++;

            // Wypełnianie kolumny od góry do dołu
            for (int i = startRow; i <= endRow; i++)
            {
                tablica[i, endCol] = num++;
            }
            endCol--;

            // Wypełnianie wiersza od prawej do lewej
            for (int i = endCol; i >= startCol; i--)
            {
                tablica[endRow, i] = num++;
            }
            endRow--;

            // Wypełnianie kolumny od dołu do góry
            for (int i = endRow; i >= startRow; i--)
            {
                tablica[i
using System;

class Program
{
    static void Main()
    {
        int rozmiar;
        int maksymalnyRozmiar = 15;

        do
        {
            Console.Write("Podaj rozmiar tablicy (liczba nieparzysta, nie większa niż {0}): ", maksymalnyRozmiar);
        } while (!int.TryParse(Console.ReadLine(), out rozmiar) || rozmiar <= 0 || rozmiar > maksymalnyRozmiar || rozmiar % 2 == 0);

        int[,] tablica = new int[maksymalnyRozmiar, maksymalnyRozmiar];

        // Inicjalizacja tablicy wartościami 0
        for (int i = 0; i < maksymalnyRozmiar; i++)
        {
            for (int j = 0; j < maksymalnyRozmiar; j++)
            {
                tablica[i, j] = 0;
            }
        }

        int srodek = maksymalnyRozmiar / 2;
        int licznikParzyste = 1;
        int licznikNieparzyste = rozmiar * rozmiar;

        int startRow = srodek;
        int endRow = srodek;
        int startCol = srodek;
        int endCol = srodek;

        while (startRow >= 0 && endRow < maksymalnyRozmiar && startCol >= 0 && endCol < maksymalnyRozmiar)
        {
            // Wypełnianie przekątnej w górę w kierunku niebieskim (liczby nieparzyste)
            for (int i = startRow; i <= endRow; i++)
            {
                tablica[i, startCol] = licznikNieparzyste;
                licznikNieparzyste--;
            }

            // Wypełnianie przekątnej w dół w kierunku zielonym (liczby parzyste)
            for (int i = startRow; i <= endRow; i++)
            {
                tablica[i, endCol] = licznikParzyste;
                licznikParzyste++;
            }

            startRow--;
            endRow++;
            startCol--;
            endCol++;
        }

        // Wyświetlanie tablicy
        for (int i = 0; i < rozmiar; i++)
        {
            for (int j = 0; j < rozmiar; j++)
            {
                Console.Write(tablica[i, j].ToString().PadLeft(2) + " ");
            }
            Console.WriteLine();
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        int rozmiar;
        int maksymalnyRozmiar = 15;

        do
        {
            Console.Write("Podaj rozmiar tablicy (liczba nieparzysta, nie większa niż {0}): ", maksymalnyRozmiar);
        } while (!int.TryParse(Console.ReadLine(), out rozmiar) || rozmiar <= 0 || rozmiar > maksymalnyRozmiar || rozmiar % 2 == 0);

        int[,] tablica = new int[maksymalnyRozmiar, maksymalnyRozmiar];

        // Inicjalizacja tablicy wartościami 0
        for (int i = 0; i < maksymalnyRozmiar; i++)
        {
            for (int j = 0; j < maksymalnyRozmiar; j++)
            {
                tablica[i, j] = 0;
            }
        }

        int srodek = maksymalnyRozmiar / 2;
        int licznikParzyste = 1;
        int licznikNieparzyste = rozmiar * rozmiar;

        int startRow = srodek;
        int endRow = srodek;
        int startCol = srodek;
        int endCol = srodek;

        while (startRow >= 0 && endRow < maksymalnyRozmiar && startCol >= 0 && endCol < maksymalnyRozmiar)
        {
            // Wypełnianie przekątnej w górę w kierunku niebieskim (liczby nieparzyste)
            for (int i = startRow; i <= endRow; i++)
            {
                tablica[i, startCol] = licznikNieparzyste;
                licznikNieparzyste--;
            }

            // Wypełnianie przekątnej w dół w kierunku zielonym (liczby parzyste)
            for (int i = startRow; i <= endRow; i++)
            {
                tablica[i, endCol] = licznikParzyste;
                licznikParzyste++;
            }

            startRow--;
            endRow++;
            startCol--;
            endCol++;
        }

        // Wyświetlanie tablicy
        for (int i = 0; i < rozmiar; i++)
        {
            for (int j = 0; j < rozmiar; j++)
            {
                Console.Write(tablica[i, j].ToString().PadLeft(2) + " ");
            }
            Console.WriteLine();
        }
    }
}
