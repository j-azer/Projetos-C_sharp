// See https://aka.ms/new-console-template for more information

using System.Globalization;

Console.WriteLine("------------------------");
Console.WriteLine("| Cupom Fiscal Simples |");
Console.WriteLine("------------------------");

int codigo, codigo1, qtd, qtd1;
double valorUnit, valorUnit1, valorTotal1, valorTotal2, valorTotalF;

Console.WriteLine("Escreva o codigo da peça: ");
codigo = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Escreva a quantidade desta peça: ");
qtd = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Escreva o valor unitário desta peça: ");
valorUnit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

Console.WriteLine("Escreva o codigo da peça: ");
codigo1 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Escreva a quantidade desta peça: ");
qtd1 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Escreva o valor unitário desta peça: ");
valorUnit1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

valorTotal1 = qtd * valorUnit;

valorTotal2 = qtd1 * valorUnit1;

valorTotalF = valorTotal1 + valorTotal2;

Console.Clear();
Console.WriteLine("----------------");
Console.WriteLine("| Cupom Fiscal |");
Console.WriteLine("----------------");
Console.WriteLine();
Console.WriteLine($"|CodigoPeça - {codigo} | Qtd - {qtd} | ValorUnit - U$ {valorUnit.ToString("F2", CultureInfo.InvariantCulture)} |");
Console.WriteLine($"|CodigoPeça - {codigo1} | Qtd - {qtd1} | ValorUnit - U$ {valorUnit1.ToString("F2", CultureInfo.InvariantCulture)} |");
Console.WriteLine();
Console.WriteLine("VALOR A PAGAR - U$ " + valorTotalF.ToString("F2", CultureInfo.InvariantCulture));
