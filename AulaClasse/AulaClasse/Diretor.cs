using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Diretor : Colaborador2
    {
        public override double CalcularSalario(double salario)
        {
            double desconto = salario * 0.77;
            return desconto;
        }
    }
}
