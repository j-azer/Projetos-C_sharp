// See https://aka.ms/new-console-template for more information


using System;
using System.Globalization;

Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("| Verificar se 2 numeros são MULTIPLOS ou NÃO MULTIPLOS |");
Console.WriteLine("---------------------------------------------------------");
Console.WriteLine();

Console.WriteLine("Digite um numero inteiro:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Digite um numero inteiro:");
int y = int.Parse(Console.ReadLine());
Console.WriteLine();

if (x % y == 0 || y % x == 0)
{
    Console.WriteLine("Esses numeros sao MULTIPLOS");
}

else
{
    Console.WriteLine("Esses numeros NAO SAO MULTIPLOS");
}

