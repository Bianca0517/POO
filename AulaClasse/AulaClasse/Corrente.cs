using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Corrente : Conta
    {
        public override double CalcularImposto(double valor)
        {
            double desconto = valor * 0.85;
            return desconto;
        }
        
    }
}
