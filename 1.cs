using System;

class Program
{
    static long Potegowanie(int podstawa, int wykladnik)
    {
        if (wykladnik == 0)
        {
            return 1;
        }
        else
        {
            long wynik = podstawa;
            for (int i = 1; i < wykladnik; i++)
            {
                wynik *= podstawa;
            }
            return wynik;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę podstawy: ");
        int podstawa = Convert.ToInt32(Console.ReadLine());

        Console.Write("Podaj liczbę wykładnika: ");
        int wykladnik = Convert.ToInt32(Console.ReadLine());

        long wynik = Potegowanie(podstawa, wykladnik);
        Console.WriteLine($"Wynik potęgowania: {wynik}");
    }
}
