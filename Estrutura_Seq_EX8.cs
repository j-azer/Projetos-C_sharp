// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System;


double preco, precofinal, desc, descf;
string resp;

do
{
    Console.WriteLine("--------------------------");
    Console.WriteLine("| DESCONTO DE UM PRODUTO |");
    Console.WriteLine("--------------------------");
    Console.WriteLine();

    Console.WriteLine("Insira o valor do Produto:");
    preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Escolha o valor do desconto entre 1 e 100:");
    desc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine();

    descf = desc / 100;

    precofinal = (preco - (preco * descf));

    Console.WriteLine("O valor a ser pago e de U$ " + precofinal.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine();

    Console.WriteLine("Quer continuar? [S/N]");
    resp = Console.ReadLine();
    Console.Clear();
}
while (resp.ToUpper() == "S");
Console.WriteLine();
Console.WriteLine("-----------------------------------------");
Console.WriteLine("-> | MUITO OBRIGADO E VOLTE SEMPRE !!!! |");
Console.WriteLine("-----------------------------------------");
