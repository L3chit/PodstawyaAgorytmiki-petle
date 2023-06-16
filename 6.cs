using System;

class Program
{
    static void Main()
    {
        int x;
        int n = 0;
        int silnia = 1;

        Console.Write("Podaj liczbę x: ");
        x = int.Parse(Console.ReadLine());

        while (silnia < x)
        {
            n++;
            silnia *= n;
        }

        if (silnia == x)
        {
            Console.WriteLine($"Liczba {x} jest silnią liczby {n}");
        }
        else
        {
            Console.WriteLine($"Liczba {x} nie jest silnią żadnej liczby");
        }
    }
}
