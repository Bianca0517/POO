using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Moto : Veiculo
    {
        public override void ValorCombustivel()
        {
            Console.WriteLine("--- Com qual combustível deseja abastecer: --- \n 1 -> Álcool (R$4,99 por litro) \n 2 -> Gasolina (R$4,99 por litro)");
            string escolha = Console.ReadLine();
            Console.WriteLine("Qual a quantidade de litros?");
            double quantidadeLitros = Convert.ToDouble(Console.ReadLine());

            if(escolha == "1")
            {
                Console.WriteLine("Você escolheu 1 -> Álcool!");
                double valorTotal = quantidadeLitros * 4.99;
                Console.WriteLine("O valor total a ser pago é de: "+ valorTotal);
            }
            else if (escolha == "2") 
            {
                Console.WriteLine("Você escolheu 2 -> Gasolina!");
                double valorTotal = quantidadeLitros * 4.99;
                Console.WriteLine("O valor total a ser pago é de: " + valorTotal);
            }
            else
            {
                Console.WriteLine("Escolha inválida!");
            }

        }
        public override void CalcularTotal()
        {
            Console.WriteLine("Qual a quantidade de KM a percorrer?");
            double quantidadeKm = Convert.ToDouble(Console.ReadLine());

            if (quantidadeKm >= 100 && quantidadeKm < 150)
            {
                double situacao = quantidadeKm * 20.00;
                Console.WriteLine("O total é de: " + situacao);
            }
            else if (quantidadeKm >= 50)
            {
                double situacao2 = quantidadeKm * 10.00;
                Console.WriteLine("O total é de: " + situacao2);
            }
            else
            {
                double situacao3 = quantidadeKm * 5.00;
                Console.WriteLine("O total é de: " + situacao3);
            }
        }
    }
}
