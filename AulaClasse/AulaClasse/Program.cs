using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instância do objeto Aluno
            //Aluno aluno = new Aluno();
            //aluno.nome = "Bianca";
            //aluno.rm = "1020";
            //aluno.email = "teste@gmail.com";
            //aluno.idade = 16;
            //aluno.cpf = "323454";
            //aluno.serie = "2EM";
            //aluno.responsavel = "Mãe";
            //aluno.altura = 1.65;

            //Console.WriteLine("O nome do aluno é" + aluno.nome);

            // Os métodos não devem ter o modificador static
            //aluno.Ler();
            //aluno.Estudar();
            //aluno.Falar();

            // Instância de um novo objeto
            //Aluno aluno1 = new Aluno();
            //aluno.rm = "1030";

            // Cachorro
            //Cachorro cachorro = new Cachorro();
            //cachorro.peso = 4.4;
            //cachorro.altura = 0.45;
            //cachorro.raca = "Poodle";
            //cachorro.tipohabitat = "Doméstico";
            //cachorro.idade = 3;
            //cachorro.cor = "Preto e Branco";
            //cachorro.nome = "Bella";
            //cachorro.porte = "Médio";


            // Funcionário
            //Funcionario funcionario = new Funcionario();
            //Console.WriteLine("Digite a sua idade");
            //funcionario.idade = Convert.ToInt32(Console.ReadLine());


            // Biblioteca
            //Biblioteca biblioteca = new Biblioteca();
            //biblioteca.cnpj = "08923456671209";
            //biblioteca.nome = "Recanto do Saber";
            //biblioteca.telefone = "";
            //biblioteca.endereco = "Rua Sargento Wilson A. Oliveira, 333";
            //biblioteca.datadefundacao = "05/04/2017";

            //Livros
            //Livros livros = new Livros();
            //livros.titulo = "A culpa é das estrelas";
            //livros.genero = "Romance";
            //livros.capa = "Dura e azul";
            //livros.autor = "John Green";

            //Cliente
            //Cliente cliente = new Cliente();
            //cliente.nome = "Bianca";
            //cliente.cpf = "64539028891";
            //cliente.email = "bianca5@gmail.com";
            //cliente.telefone = "14988304355";
            //cliente.endereco = "R. Augusto Bonini, 224";
            //cliente.idade = 16;
            //cliente.peso = 45.6;
            //cliente.altura = 1.67;

            //Empresário
            //Empresario empresario = new Empresario();
            //empresario.nome = "Murilo";
            //empresario.cpf = "3356789100";
            //empresario.idade = 23;
            //empresario.peso = 60.3;
            //empresario.altura = 1.70;
            //empresario.endereco = "R. Carlos Ferrari, 222";
            //empresario.telefone = "14988534266";
            //empresario.email = "murilo@gmail.com";
            //empresario.cargahoraria = "5:00";
            //empresario.remuneracao = 7.800;


            // Escola
            //Escola escola = new Escola();
            //escola.estrutura = "Estrutura da escola em formato de H";
            //escola.nome = "Mentes em crescimento";
            //escola.cnpj = "45623009812345";
            //escola.endereco = "R. Heitor Penteado, 22";
            //escola.datadefundacao = "17/09/2000";


            // Carro
            //Carro carro = new Carro();
            //carro.cor = "Mauvine Blue";
            //carro.modelo = "McLaren 540c";
            //carro.marca = "McLaren";
            //carro.placa = "MBB518";
            //carro.ano = "2018";

            // Jogador
            //Jogador jogador = new Jogador();
            //jogador.Correr(20, "Murilo");

            // Métodos
            // Metodos metodos = new Metodos();
            //metodos.Somar(10, 10, 10);

            //Multiplicar
            //int resultado = metodos.Multiplicar(10, 20);

            //if (resultado > 100)
            //{
            //    Console.WriteLine($"O valor {resultado} é maior que 100");
            //}

            //Par ou Ímpar
            //metodos.Multiplicar(10, 20);

            //Quando for método com return precisa de uma variável para armazenar o valor
            //string numero = metodos.Dividir();
            //Console.WriteLine(numero);

            // Salário
            //Console.WriteLine("Digite o valor do seu salário");
            //double salario = Convert.ToDouble(Console.ReadLine());

            // Variável novoSalario que armazena o retorno do cálculo do novo salário,
            //double novoSalario = metodos.Salario(salario);
            //Console.WriteLine("O novo salário é de: " + novoSalario);

            // Somar e Subtrair
            //metodos.Somar(5, 2);
            //metodos.Subtrair(3);






            //Atividade 1 - Cadastro do usuário
            //MetodosSenai metodosSenai = new MetodosSenai();
            //Console.WriteLine("Digite o seu nome");
            //metodosSenai.Nome = Console.ReadLine();

            //Console.WriteLine("Digite o seu sobrenome");
            //metodosSenai.Sobrenome = Console.ReadLine();

            //Console.WriteLine("Digite o seu endereço");
            //metodosSenai.Endereco = Console.ReadLine();

            //Console.WriteLine("Digite a sua cidade");
            //metodosSenai.Cidade = Console.ReadLine();

            //Console.WriteLine("Digite o seu estado");
            //metodosSenai.Estado = Console.ReadLine();

            //Console.WriteLine("Digite o seu país");
            //metodosSenai.Pais = Console.ReadLine();

            //metodosSenai.Dados();



            // Atividade 2- Produto
            //Console.WriteLine("Digite o nome do produto");
            //metodosSenai.NomeProduto = Console.ReadLine();

            //Console.WriteLine("Digite a marca do produto");
            //metodosSenai.MarcaProduto = Console.ReadLine();

            //Console.WriteLine("Digite o código do produto");
            //metodosSenai.CodigoProduto = Console.ReadLine();

            //metodosSenai.Produto();



            // Atividade 3- Estudante
            //Console.WriteLine("Digite o nome do aluno(a)");
            //metodosSenai.NomeAluno = Console.ReadLine();

            //Console.WriteLine("Digite a idade do aluno(a)");
            //metodosSenai.Idade = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite o nome da escola");
            //metodosSenai.NomeEscola = Console.ReadLine();

            //metodosSenai.Estudar();



            // Atividade 4- Áreas
            //Console.WriteLine("Digite a medida da base do retângulo");
            //metodosSenai.Valor1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Digite a medida da altura do retângulo");
            //metodosSenai.Valor2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Digite a medida de um dos lados do quadrado");
            //metodosSenai.Valor3 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Digite o raio do círculo");
            //metodosSenai.Raio = Convert.ToDouble(Console.ReadLine());

            //metodosSenai.AreaRetangulo();
            //metodosSenai.AreaQuadrado();
            //metodosSenai.AreaCirculo();



            // Atividade 5- Professor
            //Console.WriteLine("Digite o nome do professor");
            //metodosSenai.NomeProfessor = Console.ReadLine();

            //Console.WriteLine("Digite a idade do professor");
            //metodosSenai.IdadeProfessor = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite a matéria que o professor leciona");
            //metodosSenai.Materia = Console.ReadLine();

            //Console.WriteLine("Digite a cidade do professor");
            //metodosSenai.CidadeDoProfessor = Console.ReadLine();

            //Console.WriteLine("Digite o nome da escola que o professor trabalha");
            //metodosSenai.NomeDaEscola = Console.ReadLine();

            //metodosSenai.Professor();

            //Console.WriteLine("Digite o nome do aluno");
            //metodosSenai.NomeDoAluno = Console.ReadLine();

            //Console.WriteLine("Digite a primeira nota do aluno");
            //double nota1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Digite a segunda nota do aluno");
            //double nota2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Digite a terceira nota do aluno");
            //double nota3 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Digite a quarta nota do aluno");
            //double nota4 = Convert.ToDouble(Console.ReadLine());

            //metodosSenai.Media(nota1, nota2, nota3, nota4);



            // Atividade 6- Salário do colaborador
            //Console.WriteLine("Digite o nome do colaborador");
            //metodosSenai.NomeColaborador = Console.ReadLine();

            //Console.WriteLine("Digite a idade do colaborador");
            //metodosSenai.IdadeColaborador = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite a escolaridade do colaborador");
            //metodosSenai.Escolaridade = Console.ReadLine();

            //Console.WriteLine("Digite o CPF do colaborador");
            //metodosSenai.Cpf = Console.ReadLine();

            //Console.WriteLine("Digite o RG do colaborador");
            //metodosSenai.Rg = Console.ReadLine();

            //metodosSenai.InformacoesColaborador();

            //Console.WriteLine("Digite o salário do colaborador");
            //double salario = Convert.ToDouble(Console.ReadLine());

            //metodosSenai.SalarioColaborador(salario);



            // Atividade 7- Moeda
            //Moeda moeda = new Moeda();
            //Console.WriteLine("Digite um valor em Real para ser convertido á Dolár");
            //double valorReal = Convert.ToDouble(Console.ReadLine());
            //moeda.ConversaoParaDolar(valorReal);

            //Console.WriteLine("Digite um valor em Dolár para ser convertido á Real");
            //double valorDolar = Convert.ToDouble(Console.ReadLine());
            //moeda.ConversaoParaReal(valorDolar);

            //Console.WriteLine("Digite um valor em Real para ser convertido á Euro");
            //double valorReal2 = Convert.ToDouble(Console.ReadLine());
            //moeda.ConversaoParaEuro(valorReal2);



            //Atividade 8- Conta bancária
            //ContaBancaria contaBancaria = new ContaBancaria();
            //Console.WriteLine("Digite o nome do titular da conta");
            //contaBancaria.NomeTitular = Console.ReadLine();

            //Console.WriteLine("Digite o valor do seu saldo atual");
            //contaBancaria.SaldoAtual = Convert.ToDouble(Console.ReadLine());

            //while (contaBancaria.SaldoAtual < 0)
            //{
            //    Console.WriteLine("Digite o valor do seu saldo atual");
            //    contaBancaria.SaldoAtual = Convert.ToDouble(Console.ReadLine());
            //}

            //Console.WriteLine("Digite o valor do seu depósito");
            //double valor = Convert.ToDouble(Console.ReadLine());
            //contaBancaria.Depositar(valor);

            //Console.WriteLine("Digite o valor do seu saque");
            //double valorSacar = Convert.ToDouble(Console.ReadLine());
            //contaBancaria.Sacar(valorSacar);

            //contaBancaria.ExibirInformacoes();



            //Atividade 9- Aluno
            Aluno2 aluno2 = new Aluno2();
            double nota1 = 10;
            double nota2 = 7;
            double nota3 = 5;
            double nota4 = 6;
            double nota5 = 8;



            double total = aluno2.SomarNotas(nota1, nota2, nota3, nota4, nota5);

            Console.WriteLine($"Soma total das notas: {total}");

            string media = aluno2.CalcularMedia(total);
            Console.WriteLine($"Média: {media}");



            //double media = aluno2.SomarNotas(10, 7, 5, 6, 8);

            //aluno2.CalcularMedia();

        }
    }
}
