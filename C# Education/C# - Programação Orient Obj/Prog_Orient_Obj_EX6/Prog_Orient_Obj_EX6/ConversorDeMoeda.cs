using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Orient_Obj_EX6;

internal class ConversorDeMoeda
{
    public static double Iof = 0.06;

    public static double EuroParaReal(double quantidade, double cotacao)
    {
        double total = quantidade * cotacao;
        return total + (total * Iof);
    }

}

