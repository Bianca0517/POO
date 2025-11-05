using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Moeda
    { 
        public double ValorReal;
        public double ValorDolar;
        public double ValorReal2;

        public void ConversaoParaDolar(double valorReal)
        {
            double conversaoDolar = valorReal / 5.40; 

            Console.WriteLine($"Conversão de Real para Dólar: " + conversaoDolar);
        }
        public void ConversaoParaReal(double valorDolar)
        {
            double conversaoReal = valorDolar * 5.40;
             
            Console.WriteLine($"Conversão de Dólar para Real: " + conversaoReal);
        }
        public void ConversaoParaEuro(double valorReal2)
        {
            double conversaoEuro = valorReal2 / 6.20;

            Console.WriteLine($"Conversão de Real para Euro: " + conversaoEuro);
        }

    }
}
