// See https://aka.ms/new-console-template for more information


Console.WriteLine("--------------------");
Console.WriteLine("| Teste Matemático |");
Console.WriteLine("--------------------"); Console.WriteLine();

Console.WriteLine("Digite um número positivo e diferente de 0:");
int N = int.Parse(Console.ReadLine()); Console.WriteLine();

for (int i = 1; i <= N; i++)
{
    int a = i;
    int b = i * i;
    int c = i * i * i;
    Console.WriteLine($"{a} -> seu quadrado é {b} e o cubo é {c}");
}
