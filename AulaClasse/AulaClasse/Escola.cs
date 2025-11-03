using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Escola
    {
        public string estrutura;
        public string nome;
        public string cnpj;
        public string endereco;
        public string datadefundacao;

        public void Contratar()
        {
            Console.WriteLine("A escola está contratando");
        }
        public void Matricular()
        {
            Console.WriteLine("A escola está matriculando");
        }
    }
}
