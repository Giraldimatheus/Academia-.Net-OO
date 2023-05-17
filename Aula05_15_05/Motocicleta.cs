using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_15_05
{
    internal class Motocicleta : Veiculo
    {
        public int Cilindradas { get; set; }

        public virtual void Dirigir()
        {
            Console.WriteLine($"Estou dirigindo um carro {_marca} {_modelo} de {Cilindradas} cilindradas;.");
        }

    }
}
