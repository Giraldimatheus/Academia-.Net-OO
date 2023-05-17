using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Extras
{
    internal class Retangulo2 : IFormaGeometrica
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public double CalcularArea()
        {
            double area = Altura * Largura;
            Console.WriteLine("A área do retângulo é: " + area);
            return area;
        }

        public double CalcularPerimetro()
        {
            double perimetro = 2 * (Altura + Largura);
            Console.WriteLine("O perímetro do retângulo é: " + perimetro);
            return perimetro;
        }
    }
}
