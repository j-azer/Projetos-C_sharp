
namespace Prog_Orient_Obj_List_EX1;

internal static class Interaction
{
    public static void Start()
    {
        Console.Write("Quantos funcionários quer registrar? ");
        int numRegist = int.Parse(Console.ReadLine());
        Console.WriteLine();

        List<Employee> employees = new List<Employee>();

        for (int i = 0; i < numRegist; i++)
        {
            Console.WriteLine($"Funcionário #{i + 1}:");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine();

            employees.Add(new Employee(id, nome, salario));
        }

        Console.Write("Entre com o Id do funcionário, que terá o salário aumentado: ");
        int buscaId = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Employee funcionario = employees.Find(x => x.Id == buscaId);


        if (funcionario != null)
        {
            Console.Write("Entre com a porcentagem: ");
            double porcentagem = double.Parse(Console.ReadLine());

            funcionario.AumentoSalario(porcentagem);
        }
        else
            Console.WriteLine("Funcionário não existe!");

        Console.WriteLine();
        Console.WriteLine("Lista de Funcionários Atualizada:\n");
        
        Employee.ListarFuncionarios(employees);
        

    }
}
