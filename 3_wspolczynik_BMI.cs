using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź wagę (w kg):");
        double waga = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wprowadź wzrost (w metrach):");
        double wzrost = Convert.ToDouble(Console.ReadLine());

        double bmi = waga / (wzrost * wzrost);

        Console.WriteLine("Współczynnik BMI: " + bmi);

        Console.ReadLine();
    }
}
