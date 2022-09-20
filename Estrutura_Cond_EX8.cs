// See https://aka.ms/new-console-template for more information
using System.Globalization;


Console.WriteLine("------------------------------");
Console.WriteLine("| Calculando Imposto a PAGAR |");
Console.WriteLine("------------------------------");
Console.WriteLine();
Console.Write("Digite o seu salário: ");
double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

double imposto;

if (salario <= 2000.00)
{
    imposto = 0.0;
}
else if (salario <= 3000.00)
{
    imposto = (salario - 2000.00) * 0.08;
}
else if (salario <= 4500.00)
{
    imposto = (salario - 3000.00) * 0.18 + (1000.00 * 0.08);
}

else
{
    imposto = (salario - 4500) * 0.28 + (1500.00 * 0.18) + (1000.00 * 0.08);
}

if (imposto == 0.0)
{
    Console.WriteLine("Isento de imposto !!!");
}
else
{
    Console.WriteLine($"O imposto à PAGAR é: $ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
}