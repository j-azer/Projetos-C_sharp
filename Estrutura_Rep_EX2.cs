// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("--------------------------------");
Console.WriteLine("| Identificador de Coordenadas |");
Console.WriteLine("--------------------------------");
Console.WriteLine();
Console.WriteLine("Digite dois valores de coordenadas separados por espaço:");
string[] valores = Console.ReadLine().Split(' ');
int x = int.Parse(valores[0]);
int y = int.Parse(valores[1]);
Console.WriteLine();

while (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("1º Quadrante");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("2º Quadrante");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("3º Quadrante");
    }
    else
    {
        Console.WriteLine("4º Quadrante");
    }
    Console.WriteLine();
    Console.WriteLine("Digite dois valores de coordenadas separados por espaço:");
    valores = Console.ReadLine().Split(' ');
    x = int.Parse(valores[0]);
    y = int.Parse(valores[1]);
    Console.WriteLine();

}
Console.Clear();
Console.WriteLine("---------------------");
Console.WriteLine("| Valor Nulo... FIM |");
Console.WriteLine("---------------------");