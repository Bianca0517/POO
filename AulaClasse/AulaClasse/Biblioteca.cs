using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Biblioteca
    {
        public string cnpj;
        public string nome;
        public string telefone;
        public string endereco;
        public string datadefundacao;

        public void Emprestar()
        {
            Console.WriteLine("A biblioteca empresta livros");
        }
        public void Vender()
        {
            Console.WriteLine("A biblioteca vende livros");
        }
        public void Registrar()
        {
            Console.WriteLine("A biblioteca registra livros");
        }
    }
}
