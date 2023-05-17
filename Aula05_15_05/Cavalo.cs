using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_15_05
{
    internal class Cavalo : Animal
    {
        public string Raca { get; set; }

        public Cavalo(string nome, int idade, string raca) : base(nome, idade)
        {
            this.Raca = raca;
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Relinchando");
        }
    }
}
