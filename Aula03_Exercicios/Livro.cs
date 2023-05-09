using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Exercicios
{
    internal class Livro
    {
        private string titulo;
        public Autor autor { get; set; }

        public string GetTitulo()
        {
            return titulo;
        }
        public void SetTitulo(string titulo)
        {
            if(string.IsNullOrEmpty(titulo))
            {
                Console.WriteLine("Titulo não pode ser vazio.");
            }
            else
            {
                this.titulo = titulo;
            }
        }
        public override string ToString()
        {
            return $"Titulo: {titulo}\nAutor: {autor}";
        }

    }
}
