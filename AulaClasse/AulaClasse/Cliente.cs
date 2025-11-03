using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Cliente
    {
        public string nome;
        public string cpf;
        public string email;
        public string telefone;
        public string endereco;
        public int idade;
        public double peso;
        public double altura;

        public void Andar()
        {
            Console.WriteLine("O cliente está andando");
        }
        public void Dormir()
        {
            Console.WriteLine("O cliente está dormindo");
        }
        public void Comprar()
        {
            Console.WriteLine("O cliente está comprando");
        }
        public void Comer()
        {
            Console.WriteLine("O cliente está comendo");
        }
        public void Beber()
        {
            Console.WriteLine("O cliente está bebendo");
        }
    }
}
