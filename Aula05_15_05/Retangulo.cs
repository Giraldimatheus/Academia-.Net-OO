using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_15_05
{
    internal class Retangulo : Forma
    {
        private double _largura;
        private double _altura;

        public Retangulo(double largura, double altura)
        {
            this._largura = largura;
            this._altura = altura;
        }
        public override double CalcularArea()
        {
            return _largura * _altura;
        }
        public override double CalcularPerimetro()
        {
            return 2 * (_largura + _altura);
        }

    }
}
