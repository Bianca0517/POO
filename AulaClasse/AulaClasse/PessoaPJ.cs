using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class PessoaPJ : Pessoa
    {
        private string Cnpj = "98533461231678";
        public string RazaoSocial;

        public string cnpj
        {
            get
            {
                return Cnpj;
            }
            set
            {
                Cnpj = value;
            }
        }
  
        public void Contratar()
        {
            Console.WriteLine("A pessoa jurídica está contratando");
        }
    }
}
