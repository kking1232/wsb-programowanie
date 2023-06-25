using System;

public class RecursiveAverage
{
    public static double CalculateAverage(double[] array, int size)
    {
        if (size == 0)
            return 0;

        double sum = array[size - 1] + CalculateAverage(array, size - 1);
        return sum / size;
    }

    public static void Main()
    {
        double[] array = { 1.0, 2.0, 3.0, 4.0, 5.0 };
        int size = array.Length;

        double average = CalculateAverage(array, size);
        Console.WriteLine($"Średnia arytmetyczna: {average}");
    }
}
