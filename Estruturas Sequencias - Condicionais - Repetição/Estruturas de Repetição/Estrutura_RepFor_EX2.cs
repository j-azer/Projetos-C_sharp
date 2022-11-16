// See https://aka.ms/new-console-template for more information

Console.WriteLine("-----------------------------");
Console.WriteLine("| Verificardor de Intervalo |");
Console.WriteLine("-----------------------------");
Console.WriteLine();
Console.WriteLine("Quantos nº deseja verificar:");
int n = int.Parse(Console.ReadLine()); Console.WriteLine();

int contador_in = 0;
int contador_out = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Digite o nº:");
    int x = int.Parse(Console.ReadLine());
    if (x >= 10 && x <= 20)
    {
        contador_in = contador_in + 1;
    }
    else
    {
        contador_out = contador_out + 1;
    }
}
Console.Clear(); Console.WriteLine();
Console.WriteLine("No intervalo entre [10,20] temos: "); Console.WriteLine();
Console.WriteLine($"In -> {contador_in}");
Console.WriteLine($"Out -> {contador_out}");