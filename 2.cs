using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę wyrazów ciągu Fibonacciego do wygenerowania: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int pierwszy = 0;
        int drugi = 1;

        Console.WriteLine("Ciąg Fibonacciego:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{pierwszy} ");

            int kolejny = pierwszy + drugi;
            pierwszy = drugi;
            drugi = kolejny;
        }
    }
}
