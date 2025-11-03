using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Carro
    {
        public string cor;
        public string modelo;
        public string marca;
        public string placa;
        public string ano;

        public void Ligar()
        {
            Console.WriteLine("O carro está ligando");
        }
        public void Acelerar()
        {
            Console.WriteLine("O carro está acelerando");
        }
        public void Frear()
        {
            Console.WriteLine("O carro está freando");
        }
        public void AcenderFarol()
        {
            Console.WriteLine("O carro está acendendo o farol ");
        }
    }
}
