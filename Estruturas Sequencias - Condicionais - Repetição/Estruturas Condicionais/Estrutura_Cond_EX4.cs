// See https://aka.ms/new-console-template for more information


using System;
using System.Globalization;

Console.WriteLine("----------------------------------");
Console.WriteLine("| Verificar as horas TRABALHADAS |");
Console.WriteLine("----------------------------------");
Console.WriteLine();

int duracao;
Console.WriteLine("Digite a hora de ENTRADA:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Digite a hora de SAIDA:");
int y = int.Parse(Console.ReadLine());
Console.WriteLine();

if (x < y)
{
   duracao =  y - x;
}

else
{
    duracao = 24 - x + y;
}

Console.WriteLine("O FUNCIONARIO trabalhou: "+duracao+ " hora(s).");
