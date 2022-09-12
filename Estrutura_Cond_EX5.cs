// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

Console.WriteLine("------------------------");
Console.WriteLine("| Calculador de VENDAS |");
Console.WriteLine("------------------------");
Console.WriteLine();
Console.WriteLine("--------------- PRODUTOS ----------------");
Console.WriteLine("|                                       |");
Console.WriteLine("|CODIGO| - | ESPECIFICACAO | - | PRECOS |");
Console.WriteLine("|                                       |");
Console.WriteLine("| 1         Cachorro Quente     U$ 4.00 |");
Console.WriteLine("| 2         X-Salada            U$ 4.50 |");
Console.WriteLine("| 3         X-Bancon            U$ 5.00 |");
Console.WriteLine("| 4         Torrada Simples     U$ 2.00 |");
Console.WriteLine("| 5         Refrigerante        U$ 1.50 |");
Console.WriteLine("-----------------------------------------");
Console.WriteLine();

int codigo, qtd;
double total;

Console.WriteLine("Digite o codigo do produto:");
codigo = int.Parse(Console.ReadLine());
Console.WriteLine("Digitea quantidade consumida deste codigo:");
qtd = int.Parse(Console.ReadLine());

if(codigo == 1)
{
    total = qtd * 4.00;
}
else if (codigo == 2)
{
    total = qtd * 4.50;
}
else if (codigo == 3)
{
    total = qtd * 5.00;
}
else if (codigo == 4)
{
    total = qtd * 2.00;
}
else
{
    total = qtd * 1.50;
}
Console.Clear();
Console.WriteLine("------------------------");
Console.WriteLine("|    Valor da VENDA    |");
Console.WriteLine("------------------------");
Console.WriteLine();
Console.WriteLine($"Total: U$ {total.ToString("F2", CultureInfo.InvariantCulture)}");