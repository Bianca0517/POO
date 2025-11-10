using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Aluno3
    {
        public string nome;
        public int idade;
        public double peso;
        public double altura;

        //Privados encapsulamento
        private string cpf = "00000";
        private string rg;
        private string numeroCelular;

        //Propriedade Get e Set
        //Get = Obter
        //Set = Definir

        //Exclusivo para atributos privados
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
    }
}
