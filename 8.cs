using System;

class Program
{
    static void Main()
    {
        int dolnyPrzedzial = 1;
        int gornyPrzedzial = 20;
        int propozycja;

        Console.WriteLine("Pomyśl liczbę z przedziału 1-20.");

        while (true)
        {
            propozycja = (dolnyPrzedzial + gornyPrzedzial) / 2;
            Console.WriteLine($"Czy liczba, o której myślisz, to {propozycja}?");

            int odpowiedz = int.Parse(Console.ReadLine());

            if (odpowiedz < 0)
            {
                gornyPrzedzial = propozycja - 1;
            }
            else if (odpowiedz > 0)
            {
                dolnyPrzedzial = propozycja + 1;
            }
            else
            {
                Console.WriteLine($"Odgadłem! Liczba, o której myślałeś, to {propozycja}.");
                break;
            }
        }
    }
}
