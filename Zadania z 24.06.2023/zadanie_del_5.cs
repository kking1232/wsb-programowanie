using System;

public class PrimeDivisorsCounter
{
    public static int CountPrimeDivisors(int n)
    {
        if (n <= 5)
            return 0;

        int divisorCount = 0;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0 && IsPrime(i))
                divisorCount++;

            if (n % (n / i) == 0 && IsPrime(n / i))
                divisorCount++;
        }

        return divisorCount;
    }

    private static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    public static void Main()
    {
        int n = 15;
        int primeDivisorCount = CountPrimeDivisors(n);
        Console.WriteLine($"Liczba dzielników, które są liczbami pierwszymi: {primeDivisorCount}");
    }
}
