using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Colaborador2
    {
        public double salario;
        public virtual double CalcularSalario(double salario)
        {
            double descontoInss = salario * 0.86;
            return descontoInss;
        }
        public double CalcularIrrf(double salario)
        {
            double descontoIrrf = salario * 0.98;
            return descontoIrrf;
        }
    }
}
