using System;

class Program
{
    static void Main()
    {
        int[,] tablica = new int[10, 10];

        int num = 1;
        int startRow = 0;
        int endRow = 9;
        int startCol = 0;
        int endCol = 9;

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
                tablica[i, startCol] = num++;
            }
            startCol++;
        }

        // Wypisanie tablicy na ekranie
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
