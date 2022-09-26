// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

Console.WriteLine("-------------------");
Console.WriteLine("| MEDIA PONDERADA |");
Console.WriteLine("-------------------"); Console.WriteLine();

Console.WriteLine("Digite o número de testes que deseja fazer:");
int Nrepeat = int.Parse(Console.ReadLine()); Console.WriteLine();

for (int i = 1; i <= Nrepeat; i++)
{
    Console.WriteLine("Digite 3 nº quaisquer, em sequência e separados por espaço:"); Console.WriteLine();

    string[] line = Console.ReadLine().Split(' ');
    double a = double.Parse(line[0], CultureInfo.InvariantCulture);
    double b = double.Parse(line[1], CultureInfo.InvariantCulture);
    double c = double.Parse(line[2], CultureInfo.InvariantCulture);

    double media = ((a * 2.0) + (b * 3.0) + (c * 5.0)) / 10.0;

    Console.WriteLine();
    Console.WriteLine($"MÉDIA PONDERADA: {media.ToString("F1", CultureInfo.InvariantCulture)}"); Console.WriteLine();
}
