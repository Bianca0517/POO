using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class MetodosSenai
    {
        // 1-

        public string Nome;
        public string Sobrenome;
        public string Endereco;
        public string Cidade;
        public string Estado;
        public string Pais;

        public void Dados()
        {
            Console.WriteLine("\n Informações do usuário");
            Console.WriteLine($" Nome completo : {Nome} {Sobrenome} ");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"Cidade: {Cidade}");
            Console.WriteLine($"Estado: {Estado}");
            Console.WriteLine($"País: {Pais}");
        }

        // 2-

        public string NomeProduto;
        public string MarcaProduto;
        public string CodigoProduto;
        public int QuantidadeProduto;
        public void Produto()
        {
            Console.WriteLine($"Nome do produto: {NomeProduto}");
            Console.WriteLine($"Marca do produto: {MarcaProduto}");
            Console.WriteLine($"Código do produto: {CodigoProduto}");

            Console.WriteLine("Digite a quantidade de produtos que deseja: ");
            int QuantidadeProduto = Convert.ToInt32( Console.ReadLine() );

           if(QuantidadeProduto < 10)
            {
                int quant = QuantidadeProduto * 20;
                Console.WriteLine("Há menos de 10 produtos, o valor é de:" + quant);
            }
           else if(QuantidadeProduto < 20)
           {
                int quant2 = QuantidadeProduto * 25;
                Console.WriteLine("Há menos de 20 produtos, o valor é de: " + quant2);

           }
            else
            {
                int quant3 = QuantidadeProduto * 5;
                Console.WriteLine("O valor do produto é de: "+ quant3);
            }
        }

        //3-

        public string NomeAluno;
        public int Idade;
        public string NomeEscola;
        public void Estudar()
        {
            Console.WriteLine($"Nome do aluno(a):{NomeAluno} ");
            Console.WriteLine($"Idade do aluno(a): {Idade}");
            Console.WriteLine($"Nome da escola: {NomeEscola}");

            if(NomeEscola == "Senai" || NomeEscola == "Sesi") 
            {
                Console.WriteLine("Parabéns você está cursando em uma excelente escola");
            }
            else
            {
                Console.WriteLine("Aluno não pertence ao Senai");
            }
        }

        //4-

        public double Valor1;
        public double Valor2;
        public double Valor3;
        public double Raio;

        public void AreaRetangulo()
        {
            double areaRetangulo = Valor1 * Valor2;
            Console.WriteLine("Área do rêtangulo :" + areaRetangulo);
        }
        public void AreaQuadrado()
        {
            double areaQuadrado = Valor3 * Valor3;
            Console.WriteLine("Área do quadrado: " + areaQuadrado);
        }
        public void AreaCirculo()
        {
            double areaCirculo = 3.14 * (Raio * Raio);
            Console.WriteLine("Área do círculo: " + areaCirculo);
        }

        //5-

        public string NomeProfessor;
        public int IdadeProfessor;
        public string Materia;
        public string CidadeDoProfessor;
        public string NomeDaEscola;

        public void Professor()
        {
            Console.WriteLine($"Nome do professor(a): {NomeProfessor}");
            Console.WriteLine($"Idade do professor(a): {IdadeProfessor}");
            Console.WriteLine($"Matéria que o professor(a) leciona: {Materia}");
            Console.WriteLine($"Cidade do professor(a): {CidadeDoProfessor}");
            Console.WriteLine($"Nome da escola que o professor(a): {NomeDaEscola}");
        }

        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double Nota4;
        public string NomeDoAluno;

        public void Media(double nota1, double nota2, double nota3, double nota4)
        {
            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine($"Nome do aluno: {NomeDoAluno}");
            Console.WriteLine("Média do aluno: " + media);
        }

        //6-

        public string NomeColaborador;
        public int IdadeColaborador;
        public string Escolaridade;
        public string Cpf;
        public string Rg;

        public void InformacoesColaborador()
        {
            Console.WriteLine($"Nome do colaborador: {NomeColaborador}");
            Console.WriteLine($"Idade: {IdadeColaborador}");
            Console.WriteLine($"Escolaridade: {Escolaridade}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"RG: {Rg}");
        }

        public double Salario;

        public void SalarioColaborador(double salario)
        {
            if(Salario <= 1000)
            {
                double aumento25 = Salario * 1.25;
                Console.WriteLine($"Novo salário com o aumento de 25%: {aumento25} ");
            }
            else if(Salario <= 3000)
            {
                double aumento10 = Salario * 1.10;
                Console.WriteLine($"Novo salário com o aumento de 10%: {aumento10}");
            }
            else
            {
                double aumento5 = Salario * 1.05;
                Console.WriteLine($"Novo salário com o aumento de 5%: {aumento5}");
            }
        }

        
    }
}
