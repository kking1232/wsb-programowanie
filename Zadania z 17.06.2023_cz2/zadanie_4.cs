using System;

class Program
{
    static void Main()
    {
        int maxProby = 3;
        int proby = 0;
        int liczbaWierszy;

        do
        {
            Console.Write("Podaj liczbę wierszy (nieparzysta, większa lub równa 3): ");
            liczbaWierszy = int.Parse(Console.ReadLine());

            if (liczbaWierszy >= 3 && liczbaWierszy % 2 != 0)
            {
                RysujRomb(liczbaWierszy);
                return;
            }

            proby++;
        }
        while (proby < maxProby);

        Console.WriteLine("Nieprawidłowa wartość! Program zostaje zakończony.");
    }

    static void RysujRomb(int liczbaWierszy)
    {
        Random random = new Random();
        char znakObramowania = LosujZnak(random, new char[] { '#', '@', '|', '*' });
        char znakWnetrza = LosujZnak(random, new char[] { '.', ':', '-', '+' });

        int srodek = liczbaWierszy / 2;
        int spacje = srodek;
        int znakiObramowania = 1;

        // Rysowanie wierszy o rosnącym rozmiarze
        for (int i = 0; i < srodek; i++)
        {
            RysujWiersz(spacje, znakiObramowania, znakObramowania, znakWnetrza);
            spacje--;
            znakiObramowania += 2;
        }

        // Rysowanie wiersza środkowego
        RysujWiersz(0, liczbaWierszy, znakObramowania, znakWnetrza);

        spacje = 1;
        znakiObramowania = liczbaWierszy - 2;

        // Rysowanie wierszy o malejącym rozmiarze
        for (int i = srodek + 1; i < liczbaWierszy; i++)
        {
            RysujWiersz(spacje, znakiObramowania, znakObramowania, znakWnetrza);
            spacje++;
            znakiObramowania -= 2;
        }
    }

    static void RysujWiersz(int spacje, int znaki, char znakObramowania, char znakWnetrza)
    {
        for (int i = 0; i < spacje; i++)
        {
            Console.Write(" ");
        }

        Console.Write(znakObramowania);

        for (int i = 0; i < znaki - 2; i++)
        {
            Console.Write(znakWnetrza);
        }

        if (znaki > 1)
        {
            Console.Write(znakObramowania);
        }

        Console.WriteLine();
    }

    static char LosujZnak(Random random, char[] znaki)
    {
        int indeks = random.Next(znaki.Length);
        return znaki[indeks];
    }
}
