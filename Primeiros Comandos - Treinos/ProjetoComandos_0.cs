// See https://aka.ms/new-console-template for more information

Console.WriteLine("-----------------------");
Console.WriteLine("| Aprendendo Comandos |");
Console.WriteLine("-----------------------");
Console.WriteLine();
Console.WriteLine("Digite uma frase: ");

string frase = Console.ReadLine();
Console.WriteLine("Digite uma cor: ");
string x = Console.ReadLine();
Console.WriteLine("Digite outra cor: ");
string y = Console.ReadLine();
Console.WriteLine("Digite só mais uma cor: ");
string z = Console.ReadLine();
Console.WriteLine("Digite 3 cores em sequência, separadas por espaço e aperte ENTER: ");
string[] v = Console.ReadLine().Split(' ');
string a = v[0];
string b = v[1];
string c = v[2];
Console.WriteLine();
Console.WriteLine("Você digitou");
Console.WriteLine(frase);
Console.WriteLine();
Console.WriteLine("As primeiras cores foram: ");
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
Console.WriteLine();
Console.WriteLine("As cores digitadas em seqência são: ");
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

