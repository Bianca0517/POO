using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    // Polimorfismo com a classe Animal1, permite modificar o método de acordo com as características próprias do animal
    public class Passaro : Animal1
    {
        public override void EmitirSom()
        {
            Console.WriteLine("O passáro está cantando");
        }
    }
}
