// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

Console.WriteLine("----------------------------");
Console.WriteLine("| AREA Figuras GEOMETRICAS |");
Console.WriteLine("----------------------------");

double A, B, C, areaTri, areaC, areaQ, areaTra, areaR;
double pi = 3.14159;


Console.WriteLine("Digite um valor para A: ");
A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Digite um valor para B: ");
B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Digite um valor para C: ");
C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

areaTri = (A * C) / 2.0;
areaC = pi * C * C;
areaTra = (A + B) * C / (2.0);
areaQ = B * B;
areaR = A * B;

Console.Clear();
Console.WriteLine("----------------------------");
Console.WriteLine("| AREA Figuras GEOMETRICAS |");
Console.WriteLine("----------------------------");
Console.WriteLine();
Console.WriteLine("Para A = " +A.ToString("F1", CultureInfo.InvariantCulture)+ ", B = " +B.ToString("F1", CultureInfo.InvariantCulture) + ", C = "+C.ToString("F1", CultureInfo.InvariantCulture)+ " e Pi = "+pi.ToString("F5", CultureInfo.InvariantCulture));
Console.WriteLine();
Console.WriteLine("A área do triângulo retângulo que tem A por base e C por altura: ");
Console.WriteLine($"Area TRIANGULO = {areaTri.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine();
Console.WriteLine("A área do círculo de raio C: ");
Console.WriteLine($"Area CIRCULO = {areaC.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine();
Console.WriteLine("A área do trapézio que tem A e B por bases e C por altura: ");
Console.WriteLine($"Area TRAPEZIO = {areaTra.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine();
Console.WriteLine("A área do quadrado que tem lado B: ");
Console.WriteLine($"Area QUADRADO = {areaQ.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine();
Console.WriteLine("A área do retângulo que tem lados A e B: ");
Console.WriteLine($"Area RETANGULO = {areaR.ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine();