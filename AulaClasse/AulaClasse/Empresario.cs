using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Empresario
    {
        public string nome;
        public string cpf;
        public int idade;
        public double peso;
        public double altura;
        public string endereco;
        public string telefone;
        public string email;
        public string cargahoraria;
        public double remuneracao;

        public void Planejar()
        {
            Console.WriteLine("O empresário está planejando");
        }
        public void Investir()
        {
            Console.WriteLine("O empresário está investindo");
        }
        public void Vender()
        {
            Console.WriteLine("O empresário está vendendo");
        }
        public void Contratar()
        {
            Console.WriteLine("O empresário está contratando");
        }
    }
}
