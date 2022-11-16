using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Orient_Obj_EX5._3;


public class Alunos
{
    public String Nome;
    public double Nota1, Nota2, Nota3;

    public double NotaFinal()
    {
        return Nota1 + Nota2 + Nota3;
    }

    public bool Aprovado()
    {
        if(NotaFinal() >= 60)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public double NotaRestante()
    {
        if (Aprovado())
        {
            return 0.0;
        }
        else
        {
            return 60.0 - NotaFinal();  
        }
    }


}

