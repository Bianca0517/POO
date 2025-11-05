using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
   public class Aluno2
    {
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double Nota4;
        public double Nota5;
        public string Nome;

        public double SomarNotas(double nota1, double nota2, double nota3, double nota4, double nota5) 
        {
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.Nota3 = nota3;
            this.Nota4 = nota4;
            this.Nota5 = nota5;

            return nota1 + nota2 + nota3 + nota4 + nota5;
        }
        public string CalcularMedia(double SomarNotas)
        {
            double media = SomarNotas / 5;

            if(media > 7) 
            {
                return "Aluno aprovado";
            }
            else if(media > 5)
            {
                return "Aluno de recuperação";
            }
            else
            {
                return "Aluno reprovado";
            }
        }
    }
}
