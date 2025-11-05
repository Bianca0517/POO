using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class ContaBancaria
    {
        public string NomeTitular;
        public double SaldoAtual;

        public void Depositar(double valor)
        {
           if(valor <= 0)
            {
                Console.WriteLine("Erro! Você está tentando depositar um valor inválido");
            }
            else
            {
                this.SaldoAtual += valor;
                Console.WriteLine("Sucesso! O seu depósito foi realizado");
            }
        }
        public void Sacar(double valor)
        {
            if(valor <= 0 && valor > this.SaldoAtual) 
            {
                Console.WriteLine("Erro! Você está tentando sacar um valor inválido");
            }
            else
            {
                this.SaldoAtual -= valor;
                Console.WriteLine("Sucesso! Seu saque foi realizado");
            }

        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome do titular da conta: {this.NomeTitular}");
            Console.WriteLine($"Saldo atual da conta: {this.SaldoAtual}");
        }


    }
}
