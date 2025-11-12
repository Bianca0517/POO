using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Coordenador : Colaborador2
    {
        public override double CalcularSalario(double salario)
        {
            double desconto = salario * 0.89;
            return desconto;
        }
    }
}
