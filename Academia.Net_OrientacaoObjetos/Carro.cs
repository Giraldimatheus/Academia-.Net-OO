using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Net_OrientacaoObjetos
{
    internal class Carro
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }
        public int anoFabricacao { get; set; }

        public void exibeDados()
        {
            Console.WriteLine("Marca: "+this.Marca);
            Console.WriteLine("Modelo: "+this.Modelo);
            Console.WriteLine("Ano: " + this.anoFabricacao);
        }

    }
}
