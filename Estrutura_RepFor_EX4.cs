// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

Console.WriteLine("--------------------------");
Console.WriteLine("| VERIFICADOR DE DIVISÃO |");
Console.WriteLine("--------------------------"); Console.WriteLine();

Console.WriteLine("Digite o nº de verificações que deseja fazer:");
int Nrepeat = int.Parse(Console.ReadLine()); Console.WriteLine();

for (int i = 1; i <= Nrepeat; i++)
{
    Console.WriteLine("Escreva dois números quaisquer, em sequência e separados por espaço: "); Console.WriteLine();
    string[] numero = Console.ReadLine().Split(' '); Console.WriteLine();

    double a = double.Parse(numero[0], CultureInfo.InvariantCulture);
    double b = double.Parse(numero[1], CultureInfo.InvariantCulture);

    if (b == 0)
    {
        Console.WriteLine("Divisão IMPOSSÌVEL !!!"); Console.WriteLine();
    }
    else
    {
        double resultdiv = a / b;
        Console.WriteLine($"Resultado: {resultdiv.ToString("F1", CultureInfo.InvariantCulture)}"); Console.WriteLine();
    }
}
