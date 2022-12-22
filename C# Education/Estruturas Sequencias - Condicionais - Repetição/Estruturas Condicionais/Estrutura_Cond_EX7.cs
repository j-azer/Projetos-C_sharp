// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System;

double x, y;
string resp;

do
{
    Console.WriteLine("----------------------------------");
    Console.WriteLine("|  Identificador de Coordenadas  |");
    Console.WriteLine("----------------------------------");
    Console.WriteLine();

    Console.WriteLine("Digite a coordenada do eixo X");
    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine();
    Console.WriteLine("Digite a coordenada do eixo Y");
    y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine();


    if (x == 0 && y! > 0)
    {
        Console.WriteLine("Encontra-se no EIXO Y.");
    }
    else if (x! > 0 && y == 0)
    {
        Console.WriteLine("Encontra-se no EIXO X.");
    }
    else if (x > 0 && y > 0)
    {
        Console.WriteLine("Encontra-se no QUADRANTE 1.");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Encontra-se no QUADRANTE 3.");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Encontra-se no QUADRANTE 4.");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Encontra-se no QUADRANTE 2.");
    }
    else
    {
        Console.WriteLine("Encontra-se na ORIGEM.");
    }

    Console.WriteLine();
    Console.WriteLine("Quer continuar? [S/N]");
    resp = Console.ReadLine();
    Console.Clear();
}

while (resp.ToUpper() == "S");

Console.WriteLine("----------------------------------");
Console.WriteLine("|  Obrigado e até a Proxima !!!  |");
Console.WriteLine("----------------------------------");
Console.WriteLine();
