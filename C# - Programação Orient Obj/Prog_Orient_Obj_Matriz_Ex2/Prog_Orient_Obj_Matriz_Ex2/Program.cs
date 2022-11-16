// See https://aka.ms/new-console-template for more information

Console.Write("Digite o nº de Linhas da matriz: ");
int l = int.Parse(Console.ReadLine());

Console.Write("Digite o nº de Colunas da matriz: ");
int c = int.Parse(Console.ReadLine()); Console.WriteLine();

int[,] mat = new int[l, c];

for (int i = 0; i < l; i++)
{
    string[] values = Console.ReadLine().Split();

    for (int j = 0; j < c; j++)
    {
        mat[i, j] = int.Parse(values[j]);
    }
}
Console.WriteLine();
string resp = "";

do
{
    Console.Write("Digite o nº que deseja descobrir a posição na matriz: ");
    int x = int.Parse(Console.ReadLine());Console.WriteLine();   

    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < c; j++)
        {
            if (mat[i, j] == x)
            {
                Console.WriteLine($"Posição: ({i},{j})");

                if (j > 0)
                {
                    Console.WriteLine("Left: " + mat[i, j - 1]);
                }
                if (i > 0)
                {
                    Console.WriteLine("Up: " + mat[i - 1, j]);
                }
                if (j < c - 1)
                {
                    Console.WriteLine("Right: " + mat[i, j + 1]);
                }
                if (i < l - 1)
                {
                    Console.WriteLine("Down: " + mat[i + 1, j]);
                }
                Console.WriteLine();
            }
        }
    }
    Console.Write("Quer continuar? [S/N]: ");
    resp = Console.ReadLine(); Console.WriteLine();

} while (resp == "S" || resp == "s");

Console.WriteLine("FIM !!!");
