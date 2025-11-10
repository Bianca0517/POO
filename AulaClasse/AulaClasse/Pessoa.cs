using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Pessoa
    {
        public int Idade;
        public string Nome;
        public double Peso;
        public double Altura;
        public string Sexo;
        public string Email;
        public string Telefone;
        public string Endereco;

        public void Comer()
        {
            Console.WriteLine("A pessoa está comendo");
        }
        public void Dormir()
        {
            Console.WriteLine("A pessoa está dormindo");
        }
        public void Beber()
        {
            Console.WriteLine("A pessoa está bebendo");
        }

    }
}
