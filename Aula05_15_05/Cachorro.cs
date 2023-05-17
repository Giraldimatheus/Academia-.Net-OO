using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_15_05
{
    internal class Cachorro : Animal
    {
        public string Racao { get; set; }

        public Cachorro(string nome, int idade, string racao) : base(nome, idade)
        {
            Racao = racao;
        }

        public override void EmitirSom()
        {
            throw new NotImplementedException();
        }
    }
}
