// See https://aka.ms/new-console-template for more information

using Prog_Orient_Obj_EX4._2;
using System;
using System.Globalization;

Funcionario func1 = new Funcionario();

Console.Write("Digite o nome do funcionário: ");
func1.Nome = Console.ReadLine();

Console.Write("Digite o salario bruto do funcionário: ");
func1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Digite o imposto relativo a este funcionário: ");
func1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

Console.WriteLine($"Funcionário: {func1}");
Console.WriteLine();

Console.WriteLine("Digite o percentual de aumento deste funcionário:");
double percentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
func1.AumentarSalario(percentagem);
Console.WriteLine();

Console.WriteLine($"Dados Atualizados: {func1}");
