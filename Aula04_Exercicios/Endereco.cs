using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_Exercicios
{
    internal class Endereco
    {
        private string _rua;
        private int _numero;
        private string _complemento;

        public string Rua
        {
            get { return _rua; }
            set { _rua = value; }
        }
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        public string Complemento
        {
            get { return _complemento; }
            set { _complemento = value; }
        }

    }
}
