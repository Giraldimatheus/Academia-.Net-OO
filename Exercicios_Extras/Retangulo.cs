using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Extras
{
    internal class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }

        public void CacularArea()
        {
                this.Area = Largura * Altura;
        }
        public void CacularPerimetro(double altura, double largura)
        {
            this.Perimetro = 2 * (largura + altura);
        }
        public bool VerificarQuadrado()
        {
            return Largura == Altura;
        }
    }
}
