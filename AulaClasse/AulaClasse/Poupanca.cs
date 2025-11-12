using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Poupanca : Conta
    {
        public override double CalcularImposto(double valor)
        {
            double desconto = valor * 0.94;
            return desconto;
        }
    }
}
