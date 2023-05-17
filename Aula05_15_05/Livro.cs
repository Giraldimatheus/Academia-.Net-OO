using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_15_05
{
    internal class Livro : Produto
    {
        public string Autor { get; set; }
        public Livro(int codigo, string descricao, string autor) : base(codigo, descricao)
        {
            Autor = autor;
        }
    }
}
