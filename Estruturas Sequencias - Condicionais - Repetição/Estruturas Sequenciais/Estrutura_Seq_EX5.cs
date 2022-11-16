// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

Console.WriteLine("----------------------");
Console.WriteLine("| Calculo de Salario |");
Console.WriteLine("----------------------");

int NF, HT;
double Sal, VPH;

Console.WriteLine("Digite o Nº do funcionário: ");
NF = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
HT = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor que este funcionario recebe por hora: ");
VPH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

Sal = HT * VPH;

Console.WriteLine("Funcionário Numero: " + NF);
Console.WriteLine();
Console.WriteLine("O salario e U$ " + Sal.ToString("F2", CultureInfo.InvariantCulture));

