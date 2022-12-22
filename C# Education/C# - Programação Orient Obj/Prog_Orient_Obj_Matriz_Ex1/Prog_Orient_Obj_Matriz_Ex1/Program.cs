// See https://aka.ms/new-console-template for more information


Console.WriteLine("Qual o tamanho da matriz quadrada: ");
int n = int.Parse(Console.ReadLine());
int[,] mat = new int[n,n];

for (int i = 0; i < n; i++)
{
    string[] value = Console.ReadLine().Split(' ');

    for (int j = 0; j < n; j++)
    {
        mat[i,j] = int.Parse(value[j]);
    }
}
Console.WriteLine();

Console.WriteLine("Diagonal principal:");
for (int i = 0; i < n; i++)
{
    Console.Write($"{mat[i,i]} ");
}
Console.WriteLine();

int count = 0;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mat[i,j] < 0)
        {
            count++;
        }
    }
}
Console.WriteLine($"Números negativos: {count}");
