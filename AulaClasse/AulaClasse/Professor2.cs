using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Professor2 : Colaborador2
    {
        public override double CalcularSalario(double salario)
        {
            double desconto = salario * 0.82;
            return desconto;
        }
    }
}
