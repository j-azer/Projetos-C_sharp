using System.Globalization;

namespace Prog_Orient_Obj_List_EX1;

public class Employee
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Salario { get; private set; }
    public List<Employee> Employees { get; set; }


    public Employee(int id, string nome, double salario)
    {
        Id = id;
        Nome = nome;
        Salario = salario;
    }

    public void AumentoSalario(double porcentagem)
    {
        Salario += Salario * (porcentagem / 100);
    }

    public override string ToString()
    {
        return ($"{Id}, {Nome}, {Salario.ToString("F2", CultureInfo.InvariantCulture)}");
    }

    public static void ListarFuncionarios(IEnumerable<Employee> employees)
    {
        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee);
        }
    }

    
}
