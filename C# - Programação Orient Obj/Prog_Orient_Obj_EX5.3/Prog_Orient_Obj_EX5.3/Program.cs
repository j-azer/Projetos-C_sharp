// See https://aka.ms/new-console-template for more information



using Prog_Orient_Obj_EX5._3;
using System.Globalization;

Alunos aluno = new Alunos();

Console.Write("Nome do aluno: ");
aluno.Nome = Console.ReadLine(); Console.WriteLine();

Console.WriteLine("Digite as três notas do aluno:");
aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);Console.WriteLine();

Console.WriteLine("NOTA FINAL = "+ aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

if (aluno.Aprovado())
{
    Console.WriteLine("APROVADO");
}
else
{
    Console.WriteLine("REPROVADO");
    Console.WriteLine("FALTARAM "+ aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)+ " PONTOS");
}
