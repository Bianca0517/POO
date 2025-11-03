using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Funcionario
    {
        public string nome;
        public string cargo;
        public string cpf;
        public string endereco;
        public string telefone;
        public string email;
        public double remuneracao;
        public string cargahoraria;
        public double peso;
        public double altura;
        public int idade;


        public void Trabalhar()
        {
            Console.WriteLine("O funcionário está trabalhando");
        }
        public void Conversar()
        {
            Console.WriteLine("O funcionário está conversando");
        }
        public void Lucrar()
        {
            if (remuneracao == 0)
            {
                Console.WriteLine("Você não especificou a remuneração");
            }
            else
            {
                double novoSalario = remuneracao * 1.25; 
                Console.WriteLine("O valor do novo salário com 25% de aumento é: " + novoSalario);
            }
            
        }
        public void Comer()
        {
            Console.WriteLine("O funcionário está comendo");
        }
        public void Descansar()
        {
            Console.WriteLine("O funcionário está descansando");
        }
    }
}
