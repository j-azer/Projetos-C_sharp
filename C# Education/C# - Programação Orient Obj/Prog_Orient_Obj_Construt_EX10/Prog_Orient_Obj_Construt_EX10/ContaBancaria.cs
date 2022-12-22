using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Orient_Obj_Construt_EX10;

internal class ContaBancaria
{
    public int NumConta { get; private set; }
    public string NomeTitular { get; set; }
    public double Saldo { get; private set; }


    public ContaBancaria(int numConta, string nomeTitular, double depositoInicial)
    {
        NumConta = numConta;
        NomeTitular = nomeTitular;
        //Ao inves de fazermos (Saldo = depositoInicial) é melhor que utilizemos a funcao Deposito().
        Deposito(depositoInicial);
    }

    public ContaBancaria(int numConta, string nomeTitular)
    {
        NumConta = numConta;
        NomeTitular = nomeTitular;
    }

    public void Deposito(double quantia)
    {
        Saldo += quantia;
    }
    public void Levantamento(double quantia)
    {
        Saldo -= quantia + 5.00;
    }

    public override string ToString()
    {
        return ($"Conta: {NumConta}, Titular: {NomeTitular}, Saldo: $  {Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
