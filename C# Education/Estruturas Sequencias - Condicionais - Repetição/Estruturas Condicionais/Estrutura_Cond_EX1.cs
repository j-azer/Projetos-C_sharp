// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

Console.WriteLine("------------------------------------");
Console.WriteLine("| Verificar se o Numero e NEGATIVO |");
Console.WriteLine("------------------------------------");
Console.WriteLine();

Console.WriteLine("Digite um numero inteiro:");
int x = int.Parse(Console.ReadLine());

if (x < 0)
{
    Console.WriteLine("Esse numero e NEGATIVO");
}
else
{
Console.WriteLine("Esse numero e POSITIVO");
}

