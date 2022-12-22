// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

Console.WriteLine("---------------------");
Console.WriteLine("| CALCULAR FATORIAL |");
Console.WriteLine("---------------------"); Console.WriteLine();

Console.WriteLine("Digite um nº para calcular o fatorial:");
int N = int.Parse(Console.ReadLine()); Console.WriteLine();

int Nfatorial = 1;


for (int i = 1; i <= N; i++)
{
    Nfatorial = Nfatorial * i;

}
Console.WriteLine($"O fatorial de {N} é: {Nfatorial}");


