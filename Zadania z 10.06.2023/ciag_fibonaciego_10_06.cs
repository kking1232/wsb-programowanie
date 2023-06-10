using System;

public class Program
{
    public static void Main()
    {
        int n = 10; // liczba kolejnych wyrazów do wypisania
        
        PrintFibonacciSequence(n);
    }
    
    public static void PrintFibonacciSequence(int n)
    {
        int first = 0;
        int second = 1;
        
        Console.WriteLine("Ciąg Fibonacciego:");
        Console.Write($"{first}, {second}");
        
        for (int i = 2; i < n; i++)
        {
            int next = first + second;
            Console.Write($", {next}");
            
            first = second;
            second = next;
        }
    }
}
