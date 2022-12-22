// See https://aka.ms/new-console-template for more information

using Prog_Orient_Obj_Vetor_EX2;
using System.Globalization;

Console.Write("Quantos produtos quer cadastrar? ");
int n = int.Parse(Console.ReadLine());

Produto[] produto = new Produto[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Nome do {i+1}º produto: ");
    string name = Console.ReadLine();
    Console.Write($"Preço do {i+1}º produto: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    produto[i] = new Produto { Name = name, Price = price };

    Console.Clear();
}
Console.WriteLine();

double sum = 0.0;

for(int i = 0; i < n; i++)
{
    sum += produto[i].Price;
}

double avg = sum / n;

Console.WriteLine($"O preço medio: $ {avg.ToString("F2", CultureInfo.InvariantCulture)}");
