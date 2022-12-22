// See https://aka.ms/new-console-template for more information

using System.Globalization;

using Prog_Orient_Obj_EX2;

Funcionario f1 = new Funcionario();
Funcionario f2 = new Funcionario();

Console.Write("Digite o nome do primeiro funcionario: ");
f1.Nome = Console.ReadLine();
Console.Write("Digite o salario do primeiro funcionario: ");
f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);Console.WriteLine();


Console.Write("Digite o nome do segundo funcionario: ");
f2.Nome = Console.ReadLine();
Console.Write("Digite o salario do segundo funcionario: ");
f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);Console.WriteLine();


double mediasalarial = (f1.Salario + f2.Salario) / 2;

Console.WriteLine($"A media salarial entre eles é {mediasalarial.ToString("F2", CultureInfo.InvariantCulture)}");