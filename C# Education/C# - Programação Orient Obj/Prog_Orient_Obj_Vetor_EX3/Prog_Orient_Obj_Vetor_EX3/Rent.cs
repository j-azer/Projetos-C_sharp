using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Orient_Obj_Vetor_EX3;

internal class Rent
{
    
    public string Name { get; set; }
    public string Email { get; set; }
   
    public Rent(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public override string ToString()
    {
        return $"Nome: {Name} -> {Email}";
    }

}
