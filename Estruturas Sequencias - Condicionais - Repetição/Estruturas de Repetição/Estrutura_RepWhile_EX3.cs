// See https://aka.ms/new-console-template for more information
using System.Globalization;


int gasolina = 0, alcool = 0, diesel = 0;


Console.WriteLine("------------------------");
Console.WriteLine("| Pesquisa Combustível |");
Console.WriteLine("------------------------");
Console.WriteLine();
Console.WriteLine("------------");
Console.WriteLine("|-> MENU <-|");
Console.WriteLine("------------");
Console.WriteLine();
Console.WriteLine("[1] ALCOOL");
Console.WriteLine("[2] GASOLINA");
Console.WriteLine("[3] DIESEL");
Console.WriteLine("[4] FIM");
Console.WriteLine();
Console.WriteLine("Escolha um combustível: ");
int tipo = int.Parse(Console.ReadLine());
Console.WriteLine();

while (tipo != 4)
{

    if (tipo == 1)
    {
        alcool = alcool + 1;
    }
    else if (tipo == 2)
    {
        gasolina = gasolina + 1;
    }
    else if (tipo == 3)
    {
        diesel = diesel + 1;
    }
    Console.Write("Digite outro código:");
    tipo = int.Parse(Console.ReadLine());
    Console.WriteLine();

}

Console.Clear();
Console.WriteLine();
Console.WriteLine("MUITO OBRIGADO !!!");
Console.WriteLine();
Console.WriteLine("----------------------");
Console.WriteLine("| RESULTADO PESQUISA |");
Console.WriteLine("----------------------");
Console.WriteLine();
Console.WriteLine($"ALCOOL: {alcool}");
Console.WriteLine($"GASOLINA: {gasolina}");
Console.WriteLine($"DIESEL: {diesel}");
