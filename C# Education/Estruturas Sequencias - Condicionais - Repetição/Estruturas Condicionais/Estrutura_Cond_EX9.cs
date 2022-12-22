// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel;
using System.Globalization;



double x, y;
string resp;

do
{
    Console.WriteLine("----------------------------");
    Console.WriteLine("| VERIFICAR O MAIOR NUMERO |");
    Console.WriteLine("----------------------------");
    Console.WriteLine();
    Console.WriteLine("Digite o primeiro NUMERO: ");
    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("Digite o segundo NUMERO: ");
    y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine();

    if (x > y)
    {
        Console.WriteLine($"O Nº {x.ToString("F1", CultureInfo.InvariantCulture)} e maior que {y.ToString("F1", CultureInfo.InvariantCulture)}");
    }
    else if (y > x)
    {
        Console.WriteLine($"O Nº {y.ToString("F1", CultureInfo.InvariantCulture)} e maior que {x.ToString("F1", CultureInfo.InvariantCulture)}");
    }

    else
    {
        Console.WriteLine($"O Nº {y.ToString("F1", CultureInfo.InvariantCulture)} e igual a {x.ToString("F1", CultureInfo.InvariantCulture)}");
    }
    Console.WriteLine();
    Console.WriteLine("Quer continuar? [S/N]");
    resp = Console.ReadLine();
    Console.Clear();
}
while (resp.ToUpper() == "S");

Console.WriteLine();
Console.WriteLine("--------------------------------");
Console.WriteLine("| OBRIGADO E ATE A PROXIMA !!! |");
Console.WriteLine("--------------------------------");
