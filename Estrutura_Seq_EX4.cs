// See https://aka.ms/new-console-template for more information


using System.Globalization;

Console.WriteLine("--------------------------------------------");
Console.WriteLine("| Diferenca entre 2 Prudutos (A*B) - (C*D) |");
Console.WriteLine("--------------------------------------------");

int A, B, C, D, Resp;

Console.WriteLine("Digite um numero: ");
A = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Digite outro numero: ");
B = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Digite mais um numero: ");
C = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Digite o ultimo numero: ");
D = int.Parse(Console.ReadLine());
Console.WriteLine();

Resp = A * B - C * D;

Console.WriteLine("A DIFERNÇA é: " + Resp);
