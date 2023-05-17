using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_15_05
{
    internal class Carro : Veiculo
    {
        public int QtdeDePorta { get; set; }


        public virtual void Dirigir()
        {
            Console.WriteLine($"Estou dirigindo um carro {_marca} {_modelo} de {QtdeDePorta} portas.");
        }

    }
}
