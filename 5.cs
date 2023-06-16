using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj x:");
        int x = int.Parse(Console.ReadLine());

        double edox = 1;
        for (int i = 1; i <= n; i++)
        {
            double temp = edox;
            edox = edox + (Potega(x, i) / Silnia(i));
        }

        Console.WriteLine("e^x = " + edox);
    }

    static int Potega(int a, int b)
    {
        int temp = a;
        if (b == 0)
        {
            return 1;
        }
        for (int i = 1; i < b; i++)
        {
            a = a * temp;
        }
        return a;
    }

    static int Silnia(int a)
    {
        int wynik = 1;
        for (int i = 1; i <= a; i++)
        {
            wynik = wynik * i;
        }
        return wynik;
    }
}
