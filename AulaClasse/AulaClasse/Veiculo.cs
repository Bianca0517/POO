using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Veiculo
    {
        public string modelo;
        public string placa;

        public virtual void ValorCombustivel()
        {
            Console.WriteLine("--- Com qual combustível deseja abastecer: --- \n 1 -> Álcool (R$3,99 por litro) \n 2 -> Gasolina (R$5,99 por litro) \n 3 -> Diesel (R$6,99 por litro)");
            string escolha = Console.ReadLine();
            Console.WriteLine("Qual a quantidade de litros?");
            double quantidadeLitros = Convert.ToDouble(Console.ReadLine());
            
            if (escolha == "1")
            {
                Console.WriteLine("Você escolheu 1 -> Álcool!");
                double valorTotal = quantidadeLitros * 3.99;
                Console.WriteLine("O valor total a pagar é de: " + valorTotal);
            }
            else if(escolha == "2") 
            {
                Console.WriteLine("Você escolheu 2 -> Gasolina!");
                double valorTotal = quantidadeLitros * 5.99;
                Console.WriteLine("O valor total a pagar é de: " + valorTotal);
            }
            else if( escolha == "3")
            {
                Console.WriteLine("Você escolheu 3 -> Diesel!");
                double valorTotal = quantidadeLitros * 6.99;
                Console.WriteLine("O valor total a pagar é de: " + valorTotal);
            }
            else
            {
                Console.WriteLine("Escolha inválida!");
            }
        }

        public virtual void CalcularTotal()
        {
            Console.WriteLine("Qual a quantidade de pessoas na viagem?");
            string quantidadePessoas = Console.ReadLine();
            Console.WriteLine("Qual a quantidade de KM a percorrer?");
            double quantidadeKm = Convert.ToDouble(Console.ReadLine());

            if(quantidadePessoas == "2" && quantidadeKm > 50)
            {
                double situacao = quantidadeKm * 25.00;
                Console.WriteLine("O total é de: " + situacao);
            }
            else if(quantidadePessoas == "2" && quantidadeKm <= 50)
            {
                double situacao2 = quantidadeKm * 18.00;
                Console.WriteLine("O total é de: "+ situacao2);
            }
            else
            {
                double situacao3 = quantidadeKm * 15.00;
                Console.WriteLine("O total é de: " + situacao3);
            }
        }
    }
}
