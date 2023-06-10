using System;

class Program
{
    static void Main()
    {
        // Wczytaj liczbę n od użytkownika
        Console.WriteLine("Podaj liczbę n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pary liczb naturalnych, których suma wynosi {0}:", n);

        for (int i = 1; i <= n / 2; i++)
        {
            int j = n - i;
            Console.WriteLine("({0}, {1})", i, j);
        }
    }
}

