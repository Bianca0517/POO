using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Professor : Pessoa1
    {
        private string nif;
        private string cpf;

        public string Nif
        {
            get
            {
                return nif;
            }
            set
            {
                nif = value;
            }
        }
        public string Cpf
        {
            get
            {
                return cpf;
            }
            set
            {
                cpf = value;
            }
        }

        public void ApresentarProfessor()
        {
            Console.WriteLine("Digite o seu NIF:");
            string nif = Console.ReadLine();
            if(nif == "")
            {
                Console.WriteLine("Digite um NIF válido");
            }
            Console.WriteLine("Digite seu CPF:");
            string cpf = Console.ReadLine();    
            if(cpf == "")
            {
                Console.WriteLine("Digite um CPF válido");
            }
            Console.WriteLine("Digite a sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade <= 0)
            {
                Console.WriteLine("Digite uma idade válida");
            }
            Console.WriteLine("Digite a sua altura:");
            double altura = Convert.ToDouble(Console.ReadLine());
            if(altura <= 0)
            {
                Console.WriteLine("Digite uma altura válida");
            }
            this.nome = "Valéria";
            this.cor = "Parda";
            this.cpf = "383.423.329-28";

            Console.WriteLine("\n --- Informações do(a) professor(a) ---");
            Console.WriteLine($"Nome:{nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Cor: {cor}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"NIF: {nif}");
            Console.WriteLine($"CPF: {cpf}");
        }
    }
}
