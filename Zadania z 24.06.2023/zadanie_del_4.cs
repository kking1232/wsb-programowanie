using System;

public class RowComparator
{
    public static int[] FindClosestRows(int[,] array)
    {
        int numRows = array.GetLength(0);
        int closestRow1 = 0;
        int closestRow2 = 0;
        int minDifference = int.MaxValue;

        for (int i = 0; i < numRows - 1; i++)
        {
            for (int j = i + 1; j < numRows; j++)
            {
                int difference = CalculateRowDifference(array, i, j);
                if (difference < minDifference)
                {
                    minDifference = difference;
                    closestRow1 = i;
                    closestRow2 = j;
                }
            }
        }

        return new int[] { closestRow1, closestRow2 };
    }

    private static int CalculateRowDifference(int[,] array, int rowIndex1, int rowIndex2)
    {
        int numColumns = array.GetLength(1);
        int difference = 0;

        for (int k = 0; k < numColumns; k++)
        {
            int element1 = array[rowIndex1, k];
            int element2 = array[rowIndex2, k];
            difference += (element1 - element2) * (element1 - element2);
        }

        return difference;
    }

    public static void Main()
    {
        int[,] array = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
            { 10, 11, 12 }
        };

        int[] closestRows = FindClosestRows(array);
        Console.WriteLine($"Najbliższe wiersze: {closestRows[0]}, {closestRows[1]}");
    }
}
