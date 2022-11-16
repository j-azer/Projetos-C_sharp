// See https://aka.ms/new-console-template for more information

Console.WriteLine("---------------------");
Console.WriteLine("| Verificador IMPAR |");
Console.WriteLine("---------------------");
Console.WriteLine();
Console.Write("Digite um nº inteiro de 1 à 1000:");
int X = int.Parse(Console.ReadLine()); Console.WriteLine();
Console.WriteLine("Os nº IMPARES neste intervalo são:");
for (int i = 1; i <= X; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}
