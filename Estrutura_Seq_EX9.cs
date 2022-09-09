// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

double aumentoI, aumentoF, salarioI, salarioF;
string resp;

do
{
    Console.WriteLine("------------------------------");
    Console.WriteLine("| CALCULO AUMENTO DE SALARIO |");
    Console.WriteLine("------------------------------");
    Console.WriteLine();


    Console.WriteLine("Insira o valor do seu salário atual do funcionário:");
    salarioI = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine();
    Console.WriteLine("Insira o percentual de aumento que será concedido, entre 1% e 100%:");
    aumentoI = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine();

    aumentoF = aumentoI / 100;

    salarioF = salarioI + (salarioI * aumentoF);

    Console.WriteLine("O NOVO SALARIO SERA DE -> U$ " + salarioF.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine();
    Console.WriteLine("Quer continuar? [S/N]");
    resp = Console.ReadLine();
    Console.Clear();
} 
while (resp.ToUpper() == "S");

Console.WriteLine("-----------------------------");
Console.WriteLine("| PARABENS PELO AUMENTO !!! |");
Console.WriteLine("-----------------------------");