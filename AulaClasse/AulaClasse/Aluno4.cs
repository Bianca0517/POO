using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Aluno4 : Pessoa1
    {
        private string ra;

        public string Ra
        {
            get
            {
                return ra;
            }
            set
            {
                ra = value;
            }
        }

        public void ApresentarAluno()
        {
            this.ra = "3083";
            this.nome = "Bianca";
            this.idade = 16;
            this.cor = "Parda";
            this.altura = 1.60;

            Console.WriteLine("\n --- Informações do aluno ---");
            Console.WriteLine($"RA: {ra}");
            Console.WriteLine($"Nome do aluno: {nome}");
            Console.WriteLine($"Idade do aluno: {idade}");
            Console.WriteLine($"Cor do aluno: {cor}");
            Console.WriteLine($"Altura do aluno: {altura}");
        }

    }
}
