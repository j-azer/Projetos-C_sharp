// See https://aka.ms/new-console-template for more information



Console.WriteLine("----------------------------");
Console.WriteLine("| VERIFICADOR DE DIVISORES |");
Console.WriteLine("----------------------------"); Console.WriteLine();

Console.WriteLine("Digite um nº para calcular os seus divisores:");
int N = int.Parse(Console.ReadLine()); Console.WriteLine();
Console.WriteLine("Os seus divisores são:"); Console.WriteLine();


for (int i = 1; i <= N; i++)
{
    
    if (N % i == 0)
    {
        Console.WriteLine(i);
    }
}

