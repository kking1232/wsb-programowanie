using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę naturalną x: ");
        int x = GetIntegerInput();

        Console.Write("Podaj liczbę całkowitą nieujemną n: ");
        int n = GetNonNegativeIntegerInput();

        int result = Power(x, n);

        Console.WriteLine($"Wynik obliczony przez program: {result}");

        int expected = (int)Math.Pow(x, n);
        Console.WriteLine($"Wynik oczekiwany: {expected}");

        Console.WriteLine($"Czy wyniki są zgodne? {result == expected}");

        Console.ReadLine();
    }

    static int Power(int x, int n)
    {
        int result = x;

        for (int i = 1; i < n; i++)
        {
            int temp = result;
            for (int j = 1; j < x; j++)
            {
                result += temp;
            }
        }

        return result;
    }

    static int GetIntegerInput()
    {
        int value;
        while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
        {
            Console.Write("Podaj poprawną liczbę naturalną: ");
        }
        return value;
    }

    static int GetNonNegativeIntegerInput()
    {
        int value;
        while (!int.TryParse(Console.ReadLine(), out value) || value < 0)
        {
            Console.Write("Podaj poprawną liczbę całkowitą nieujemną: ");
        }
        return value;
    }
}
