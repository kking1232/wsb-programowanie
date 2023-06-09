using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź 4 liczby całkowite:");

        Console.Write("Liczba a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Liczba b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Liczba c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.Write("Liczba d: ");
        int d = Convert.ToInt32(Console.ReadLine());

        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwiązania");
        }
        else
        {
            int x = (a * d) + (b * c);
            int y = b * d;

            Console.WriteLine("Licznik (x): " + x);
            Console.WriteLine("Mianownik (y): " + y);
        }

        Console.ReadLine();
    }
}
