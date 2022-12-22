// See https://aka.ms/new-console-template for more information

using System.Globalization;


Console.WriteLine("--------------------------");
Console.WriteLine("Aprendendo Sobre .Parse();");
Console.WriteLine("--------------------------");
Console.WriteLine();

Console.WriteLine("Digite um numero:");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Escreva uma letra:");
char ch = char.Parse(Console.ReadLine());

Console.WriteLine("Escreva um numero decimal:");
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

Console.WriteLine("Digite seu Primeiro Nome, Sexo [F/M], Idade e Altura, na mesma linha, separado por espaço e aperte ENTER:");
string[] vet = Console.ReadLine().Split(' ');
string nome = vet[0];
char sexo = char.Parse(vet[1]);
int idade = int.Parse(vet[2]);
double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
Console.WriteLine();
Console.WriteLine("Você digitou:");
Console.WriteLine(n1);
Console.WriteLine(ch);
Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine();
Console.WriteLine("Seu nome é " + nome + ", você é do sexo " + sexo + ", você tem " + idade + " anos de idade e sua altura é " + altura.ToString("F2", CultureInfo.InvariantCulture)+".");
