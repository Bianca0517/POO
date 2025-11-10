using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Pessoa1
    {
        public string nome;
        public int idade;
        public string cor;
        public double altura;
        private string rg;
        private string cpf;
        private string cidade;
        private string estado;

        public string Rg
        {
            get
            {
                return rg;
            }
            set
            {
                rg = value;
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
        public string Cidade
        {
            get
            {
                return cidade;
            }
            set
            {
                cidade = value;
            }
        }
        public string Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }
        public void ApresentarPessoa()
        {
            this.nome = "Murilo";
            this.idade = 18;
            this.cor = "Pardo";
            this.altura = 1.70;
            this.rg = "65.766.122-9";
            this.cpf = "303.474.321-22";
            this.cidade = "Garça";
            this.estado = "São Paulo";

            Console.WriteLine("\n--- Informações do usuário --- ");
            Console.WriteLine($"Nome: {nome} ");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Cor: {cor}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"RG: {rg}");
            Console.WriteLine($"CPF: {cpf}");
            Console.WriteLine($"Cidade: {cidade}");
            Console.WriteLine($"Estado: {estado}");
        }


    }
}
