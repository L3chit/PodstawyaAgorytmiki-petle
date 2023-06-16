using System;

class Program
{
    static void Main()
    {
        decimal kwotaPoczatkowa;
        decimal oprocentowanie;
        int liczbaMiesiecy;

        Console.Write("Podaj kwotę początkową wpłacaną na konto oszczędnościowe: ");
        kwotaPoczatkowa = decimal.Parse(Console.ReadLine());

        Console.Write("Podaj oprocentowanie konta w skali roku: ");
        oprocentowanie = decimal.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę miesięcy oszczędzania: ");
        liczbaMiesiecy = int.Parse(Console.ReadLine());

        decimal podatekBelki = 0.19m;

        decimal kwotaKoncowa = kwotaPoczatkowa * (1 + oprocentowanie / 100) * (decimal)Math.Pow((double)(1 + 1 / (12 * 100)), liczbaMiesiecy);
        decimal kwotaZarobiona = kwotaKoncowa - kwotaPoczatkowa;
        decimal podatek = kwotaZarobiona * podatekBelki;
        decimal kwotaZarobionaPoPodatku = kwotaZarobiona - podatek;

        Console.WriteLine($"Kwota zarobiona (przed opodatkowaniem): {kwotaZarobiona}");
        Console.WriteLine($"Podatek Belki: {podatek}");
        Console.WriteLine($"Kwota zarobiona (po opodatkowaniu): {kwotaZarobionaPoPodatku}");
        Console.WriteLine($"Kwota końcowa na koncie oszczędnościowym: {kwotaKoncowa}");
    }
}