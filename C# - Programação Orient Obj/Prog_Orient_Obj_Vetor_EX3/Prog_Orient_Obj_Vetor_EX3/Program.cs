// See https://aka.ms/new-console-template for more information

using Prog_Orient_Obj_Vetor_EX3;

Rent[] rents = new Rent[10];

Console.Write("Quantos alugueis quer inserir? ");
int n = int.Parse(Console.ReadLine()); Console.WriteLine();

for(int i = 0; i < n; i++)
{
    Console.Write("Nome do locatário: ");
    string name = Console.ReadLine();
    Console.Write("Email do locatário: ");
    string email = Console.ReadLine();
    Console.Write("Numero do quarto: ");
    int room = int.Parse(Console.ReadLine());
    Console.WriteLine();

    rents[room] = new Rent (name, email);
}
Console.WriteLine();

Console.WriteLine("Quartos Ocupados:");
Console.WriteLine();

for (int i = 0; i < 10; i++)
{
    if(rents[i] != null)
    {
        Console.WriteLine($"#{i}:");
        Console.WriteLine($"{rents[i]}");
        Console.WriteLine();
    }
}

