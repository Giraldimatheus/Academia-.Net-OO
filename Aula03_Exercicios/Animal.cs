using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Exercicios
{
    internal class Animal
    {
        public string nome { get; set; }
        public string especie { get; set; }
        public int idade { get; set; }
        public string somEmitido { get; set; }

        public void EmitirSom(string som)
        {
            this.somEmitido = som;
        }

        public override string ToString()
        {
            return $"Nome: {nome}\nEspecie: {especie}\nSom que emite: {somEmitido}";
        }
    }
}
