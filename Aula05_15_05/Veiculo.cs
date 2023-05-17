using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_15_05
{
    internal class Veiculo
    {
        public string _marca;
        public string _modelo;
        public int _potencia;
        public virtual void Ligar()
        {
            Console.WriteLine("Oi, eu sou o veiculo ligado.");
        }
        public virtual void Dirigir()
        {
            Console.WriteLine($"Estou dirigindo um carro {_marca} {_modelo}");
        }
    }
}
