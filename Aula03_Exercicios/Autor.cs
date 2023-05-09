using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Exercicios
{
    internal class Autor
    {
        private string nome { get; set; }

        public string GetNome() { return nome; }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public override string ToString()
        {
            return this.nome;
        }
    }
}
