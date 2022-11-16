// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

using Prog_Orient_Obj_EX3._1;

Retangulo medida = new Retangulo();

Console.Write("Digite a Largura do retângulo: ");
medida.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);Console.WriteLine();

Console.Write("Digite a Altura do retângulo: ");
medida.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);Console.WriteLine();

Console.WriteLine($"AREA: {medida.Area().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"PERIMETRO: {medida.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"DIAGONAL: {medida.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");