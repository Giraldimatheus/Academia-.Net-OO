using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Extras
{
    internal class Livro
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }

        public override string ToString()
        {
            return $"Nome do Livro: {Nome}, Autor {Autor}, Publicado em: {AnoPublicacao}, Categoria: {Categoria}, Preço: {Preco}";
        }


        public void Remove(List<Livro> livros)
        {
            livros.Remove(this);
        }




    }
}
