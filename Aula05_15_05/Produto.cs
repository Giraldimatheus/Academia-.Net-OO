using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_15_05
{
    internal class Produto
    {
        private int _codigo;
        private string _descricao;

        public Produto(int codigo, string descricao)
        {
            _codigo = codigo;
            _descricao = descricao;
        }
    }
}
