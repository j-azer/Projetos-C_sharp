// See https://aka.ms/new-console-template for more information



using System.Globalization;

Console.WriteLine("-------------------");
Console.WriteLine("| Area do CIRCULO |");
Console.WriteLine("-------------------");

double r, pi, area;
pi = 3.14159;

Console.WriteLine("Digite o raio do circulo: ");
r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

area = pi * (r * r);

Console.WriteLine("A area do circulo é: " + area.ToString("F4", CultureInfo.InvariantCulture));
