using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class PessoaPF : Pessoa
    {
        private string Cpf = "6589023615";
        public string Rg;

        public string cpf
        {
            get
            {
                return Cpf;
            }
            set
            {
                Cpf = value;
            }
        }
        public void Comprar()
        {
            Console.WriteLine("A pessoa física está comprando");
        }

    }
}
