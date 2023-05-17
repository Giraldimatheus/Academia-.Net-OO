using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_15_05
{
    internal class Circulo : Forma
    {
        private double _resultado;

        private double _raio;

        public Circulo(double raio)
        {
            this._raio = raio;
        }
        public override double CalcularArea()
        {
            return Math.PI * _raio * _raio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * _raio;
        }

    }
}
