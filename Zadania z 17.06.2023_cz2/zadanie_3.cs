using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj wysokość trójkąta: ");
        int wysokosc = int.Parse(Console.ReadLine());

        RysujTrojkat(wysokosc);
    }

    static void RysujTrojkat(int wysokosc)
    {
        int szerokosc = wysokosc * 2 - 1;
        int spacje = szerokosc / 2;
        int znakiPlus = 1;

        for (int i = 0; i < wysokosc; i++)
        {
            for (int j = 0; j < spacje; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < znakiPlus; j++)
            {
                Console.Write("+");
            }

            Console.WriteLine();

            spacje--;
            znakiPlus += 2;
        }
    }
}
