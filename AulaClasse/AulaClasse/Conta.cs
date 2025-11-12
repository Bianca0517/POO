using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Conta
    {
        public string agencia;
        public string conta;
        public string nomeTitular;

        public virtual double CalcularImposto(double valor)
        {
            double descontoPadrao = valor * 0.96;
            return descontoPadrao;
        }

    }
}
