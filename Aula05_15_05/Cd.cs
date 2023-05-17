using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_15_05
{
    internal class Cd : Produto
    {
        public string Artista { get; set; }

        public Cd(int codigo, string descricao, string artista) : base(codigo, descricao)
        {
            Artista = artista;
        }
    }
}
