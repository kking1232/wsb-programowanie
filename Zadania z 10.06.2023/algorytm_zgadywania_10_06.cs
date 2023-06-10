using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pomyśl liczbę z przedziału od 1 do 20.");

        int dolnaGranica = 1;
        int gornaGranica = 20;
        int propozycja;

        do
        {
            // Propozycja to średnia arytmetyczna aktualnej dolnej i górnej granicy
            propozycja = (dolnaGranica + gornaGranica) / 2;

            Console.WriteLine("Czy liczba, którą masz na myśli, to {0}? (wpisz: -1, jeśli mniejsza, 1 jeśli większa, 0 jeśli zgadłem)", propozycja);

            int odpowiedz = Convert.ToInt32(Console.ReadLine());

            if (odpowiedz == -1)
            {
                gornaGranica = propozycja - 1;
            }
            else if (odpowiedz == 1)
            {
                dolnaGranica = propozycja + 1;
            }
            else if (odpowiedz != 0)
            {
                Console.WriteLine("Niepoprawna odpowiedź. Wpisz -1, 1 lub 0.");
            }
        }
        while (propozycja != 0);

        Console.WriteLine("Zgadłem! Szukana liczba to {0}.", propozycja);
    }
}
