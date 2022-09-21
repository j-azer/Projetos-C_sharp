// See https://aka.ms/new-console-template for more information

using System.Globalization;



Console.WriteLine("------------------------");
Console.WriteLine("| Verificador de Senha |");
Console.WriteLine("------------------------");
Console.WriteLine();
Console.WriteLine("Bem vindo ao sistema !!! Digite sua senha de acesso: ");
int senha = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Clear();    

while (senha != 2002)
{
    Console.WriteLine("------------------------");
    Console.WriteLine("| Verificador de Senha |");
    Console.WriteLine("------------------------");
    Console.WriteLine();
    Console.WriteLine("Senha inválida... Digite novamente: ");
    senha = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Clear();
}
Console.WriteLine("------------------------");
Console.WriteLine("| Verificador de Senha |");
Console.WriteLine("------------------------");
Console.WriteLine();
Console.WriteLine("Acesso Permitido !!!");
