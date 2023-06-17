using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Pierwsze " + n + " liczb pierwszych:");

        int liczba = 2; // Liczba pierwsza, od której zaczynamy szukanie
        int licznik = 0; // Licznik znalezionych liczb pierwszych

        while (licznik < n)
        {
            if (CzyLiczbaPierwsza(liczba))
            {
                Console.WriteLine(liczba);
                licznik++;
            }

            liczba++;
        }
    }

    static bool CzyLiczbaPierwsza(int liczba)
    {
        if (liczba < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
