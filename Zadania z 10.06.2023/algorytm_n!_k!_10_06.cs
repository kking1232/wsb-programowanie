using System;

public class Program
{
    public static void Main()
    {
        int n, k;

        do
        {
            Console.Write("Podaj liczbę n (n >= 5): ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < 5);

        do
        {
            Console.Write("Podaj liczbę k (k >= 5): ");
        } while (!int.TryParse(Console.ReadLine(), out k) || k < 5);

        if (n < k)
        {
            Console.WriteLine("Błąd: n musi być większe lub równe k.");
            return;
        }

        long result = CalculateExpression(n, k);

        Console.WriteLine($"Wynik: m = {result}");
    }

    public static long CalculateExpression(int n, int k)
    {
        long nFactorial = CalculateFactorial(n);
        long kFactorial = CalculateFactorial(k);

        long m = (nFactorial - kFactorial) / kFactorial;

        return m;
    }

    public static long CalculateFactorial(int number)
    {
        long factorial = 1;

        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}
