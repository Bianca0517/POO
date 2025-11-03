using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Livros
    {
        public string titulo;
        public string genero;
        public string capa;
        public string autor;

        public void Abrir ()
        {
            Console.WriteLine("O livro foi aberto");
        }
        public void Folear()
        {
            Console.WriteLine("O livro foi folheado");
        }
        public void Fechar()
        {
            Console.WriteLine("O livro foi fechado");
        }
    }
}
