// See https://aka.ms/new-console-template for more information


using System;
using System.Globalization;

Console.WriteLine("----------------------------------------");
Console.WriteLine("| Verificar se o Numero e PAR ou IMPAR |");
Console.WriteLine("----------------------------------------");
Console.WriteLine();

Console.WriteLine("Digite um numero inteiro:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine();

if (x % 2 == 0)
{
    Console.WriteLine("Esse numero e PAR");
}

else
{
    Console.WriteLine("Esse numero e IMPAR");
}
