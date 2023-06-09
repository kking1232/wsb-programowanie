using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź dwie liczby:");

        // Wczytanie pierwszej liczby
        Console.Write("Liczba 1: ");
        double liczba1 = Convert.ToDouble(Console.ReadLine());

        // Wczytanie drugiej liczby
        Console.Write("Liczba 2: ");
        double liczba2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wybierz działanie:");
        Console.WriteLine("1. Dodawanie");
        Console.WriteLine("2. Odejmowanie");
        Console.WriteLine("3. Mnożenie");
        Console.WriteLine("4. Dzielenie");

        // Wczytanie numeru działania
        Console.Write("Numer działania: ");
        int numerDzialania = Convert.ToInt32(Console.ReadLine());

        double wynik = 0;

        // Wykonanie odpowiedniego działania
        switch (numerDzialania)
        {
            case 1:
                wynik = liczba1 + liczba2;
                break;
            case 2:
                wynik = liczba1 - liczba2;
                break;
            case 3:
                wynik = liczba1 * liczba2;
                break;
            case 4:
                if (liczba2 != 0)
                {
                    wynik = liczba1 / liczba2;
                }
                else
                {
                    Console.WriteLine("Nie można dzielić przez zero. Wynik: {0}/0", liczba1);
                    Console.ReadLine();
                    return;
                }
                break;
            default:
                Console.WriteLine("Nieprawidłowy numer działania.");
                Console.ReadLine();
                return;
        }

        // Wyświetlenie wyniku
        Console.WriteLine("Wynik: " + wynik);

        Console.ReadLine();
    }
}
