using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_15_05
{
    internal class VeiculoEletrico : Veiculo
    {
        public double _autonomia;

        public void Ligar(int valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Sem bateria");
            }
            else
            {
                Console.WriteLine("Veiculo ligado");
            }
        }
        public void Carregar()
        {
            this._autonomia += 10;
            Console.WriteLine("Carreguei 10%");
        }
    }
}
