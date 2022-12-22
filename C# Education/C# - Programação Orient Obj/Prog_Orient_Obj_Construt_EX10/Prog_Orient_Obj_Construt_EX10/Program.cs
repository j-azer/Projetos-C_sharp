// See https://aka.ms/new-console-template for more information


using System.Globalization;
using Prog_Orient_Obj_Construt_EX10;

ContaBancaria cb;

Console.Write("Entre com o número da conta: ");
int nconta = int.Parse(Console.ReadLine());

Console.Write("Entre com o nome do titular da conta: ");
string nome = Console.ReadLine();

Console.Write("Deseja fazer um depósito um deposito inicial? [S/N]: ");
string resp = Console.ReadLine();

if (resp.ToUpper() == "S")
{
    Console.Write("Entre com o valor que será depositado: ");
    double dpinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    cb = new ContaBancaria(nconta, nome, dpinicial);
}
else
{
    cb = new ContaBancaria(nconta, nome);
}




Console.WriteLine();
Console.WriteLine($"Dados da conta: ");
Console.WriteLine(cb); Console.WriteLine();

Console.Write("Entre com um valor de Depósito: ");
double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
cb.Deposito(valor);
Console.WriteLine($"Dados da conta atualizados: ");
Console.WriteLine(cb); Console.WriteLine();

Console.Write("Entre com um valor do Levantamento: ");
cb.Levantamento(valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
Console.WriteLine($"Dados da conta atualizados: ");
Console.WriteLine(cb);