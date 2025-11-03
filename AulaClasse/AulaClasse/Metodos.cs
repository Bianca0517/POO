using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Metodos
    {
        public int Valor1;
        public int Valor2;
        public int Valor3;

        public void Somar (int valor1, int valor2, int valor3)
        {
            this.Valor1 = valor1;
            this.Valor2 = valor2;
            this.Valor3 = valor3;

            int resultado = Valor1 + Valor2 + Valor3;
            Console.WriteLine("A soma dos valores é de: " + resultado);
        }

        //void é usado para método sem retorno
        public int Multiplicar (int valor1, int valor2)
        {
            this.Valor1 = valor1;
            this.Valor2 = valor2;

            return Valor1 * Valor2; 

        }
        public string Dividir ()
        {
            // Chamada do método multiplicar
            int resultado = Multiplicar(Valor1, Valor2);

            if( resultado % 2 == 0) 
            {
                return "Valor par";
            }
            else 
            {
                return "Valor ímpar";
            }
        }
       
        public double Salario (double salario)
        {

            if (salario >= 2000)
            { 
                return salario * 1.2754;
            }
            else
            {
                return salario * 1.1523;
            }
                
        }
        public int Somar (int valor1, int valor2)
        {
            this.Valor1 = valor1;
            this.Valor2 = valor2;

            return Valor1 + Valor2; 
        }
        public void Subtrair (int valor3)
        {
            int resultado = Somar(Valor1, Valor2);

            if(valor3 > resultado)
            {
                Console.WriteLine("O valor da subtração é maior");
            }
            else
            {
                Console.WriteLine("O valor da soma é maior");
            }
        }
    }
}
