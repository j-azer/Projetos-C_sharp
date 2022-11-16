// See https://aka.ms/new-console-template for more information
using System.Globalization;



Console.Write("Quantas alturas quer introduzir? ");
int tamVetor = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double[] alturas = new double[tamVetor];

for (int i = 0; i < tamVetor; i++)
{
    Console.Write($"{i+1}º Altura: ");
    alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}
Console.WriteLine();

double sum = 0.0;
for (int i = 0; i < tamVetor; i++)
{
    sum += alturas[i];
}

double media = sum / tamVetor;

Console.WriteLine($"Media das alturas: {media.ToString("F2", CultureInfo.InvariantCulture)}");