using System;

class Program
{
    static void Main()
    {
        int n, k;
        
        do
        {
            Console.Write("Podaj liczbę n (n >= 5): ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < 5);

        do
        {
            Console.Write("Podaj liczbę k (k >= 5): ");
        } while (!int.TryParse(Console.ReadLine(), out k) || k < 5);

        long silniaN = ObliczSilnie(n);
        long silniaK = ObliczSilnie(k);

        long wynik = (silniaN - silniaK) / silniaK;

        Console.WriteLine($"Wynik: {wynik}");
    }

    static long ObliczSilnie(int liczba)
    {
        long silnia = 1;

        for (int i = 2; i <= liczba; i++)
        {
            silnia *= i;
        }

        return silnia;
    }
}
