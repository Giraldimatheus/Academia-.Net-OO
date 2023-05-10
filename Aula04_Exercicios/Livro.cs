using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_Exercicios
{
    internal class Livro
    {
        private string _titulo;
        private Autor autor;

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }
        public Autor Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public override string ToString()
        {
            return $"Titulo: {Titulo}\nAutor: {autor}";
        }

    }
}
