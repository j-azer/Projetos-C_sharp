// See https://aka.ms/new-console-template for more information

using System.Globalization;

//Declaração de variável

double larg, comp, precoMetroQuad, area, preco;

Console.WriteLine("---------------------------------------");
Console.WriteLine("|  Calculando o VALOR do seu TERRENO  |");
Console.WriteLine("---------------------------------------");
Console.WriteLine();

Console.WriteLine("Qual a largura do seu terreno: ");
larg = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();
Console.WriteLine("Qual o comprimento do seu terreno: ");
comp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();
Console.WriteLine("Qual o preço do metro quadrado do seu terreno: ");
precoMetroQuad = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

area = larg * comp;

preco = area * precoMetroQuad;

Console.WriteLine();
Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine();
Console.WriteLine("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine();
