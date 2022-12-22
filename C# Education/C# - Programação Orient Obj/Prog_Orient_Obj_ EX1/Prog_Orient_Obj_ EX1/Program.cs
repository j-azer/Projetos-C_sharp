// See https://aka.ms/new-console-template for more information

using Prog_Orient_Obj__EX1;

Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();

Console.Write("Digite o nome da primeira pessoa: ");
p1.Nome = Console.ReadLine();

Console.Write("Digite a idade da primeira pessoa: ");
p1.Idade = int.Parse(Console.ReadLine());Console.WriteLine();

Console.Write("Digite o nome da segunda pessoa: ");
p2.Nome = Console.ReadLine();

Console.Write("Digite a idade da segunda pessoa: ");
p2.Idade = int.Parse(Console.ReadLine());Console.WriteLine();


if (p1.Idade > p2.Idade)
{
    Console.WriteLine($"A pessoa mais velha é {p1.Nome}");
}
else
{
    Console.WriteLine($"A pessoa mais velha é {p2.Nome}");
}
    