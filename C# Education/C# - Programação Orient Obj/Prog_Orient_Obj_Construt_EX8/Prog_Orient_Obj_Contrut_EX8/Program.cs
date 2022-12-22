// See https://aka.ms/new-console-template for more information


using Prog_Orient_Obj_Construt_EX8;
using System.Globalization;



Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: "); 
string nome = Console.ReadLine(); Console.WriteLine();

Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); Console.WriteLine();

Console.Write("Quantidade no estoque: ");
int quantidade = int.Parse(Console.ReadLine()); Console.WriteLine();

Produto p = new Produto(nome, preco, quantidade);

Console.WriteLine($"Dados do produto: {p}"); Console.WriteLine();

Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
int qtd = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qtd);
Console.WriteLine();

Console.WriteLine($"Dados atualizados: {p}");
Console.WriteLine();

Console.Write("Digite o número de produtos a ser removido do estoque: ");
qtd = int.Parse(Console.ReadLine());
p.RemoverProdutos(qtd);
Console.WriteLine();

Console.WriteLine($"Dados atualizados: {p}");