// See https://aka.ms/new-console-template for more information


using System.Globalization;

Console.WriteLine("-------------------");
Console.WriteLine("| Somando NUMEROS |");
Console.WriteLine("-------------------");

int n1, n2, soma;
 
Console.WriteLine("Digite um numero: ");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Digite outro numero: ");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine();

soma = n1 + n2;

Console.WriteLine("A soma é: " + soma);
