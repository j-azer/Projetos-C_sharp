// See https://aka.ms/new-console-template for more information


using Prog_Orient_Obj_EX6;
using System.Globalization;

Console.Write("Qual é a cotação do Euro? ");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); Console.WriteLine();

Console.Write("Quantos Euros você vai comprar? ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); Console.WriteLine();

double result = ConversorDeMoeda.EuroParaReal(quantia, cotacao);
Console.WriteLine($"Valor a ser pago é R$ {result.ToString("F2", CultureInfo.InvariantCulture)}");
