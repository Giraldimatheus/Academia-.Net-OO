using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Extras
{
    internal class Circulo : IFormaGeometrica
    {

        public double Raio { get; set; }

        public double CalcularArea()
        {
            double area = Math.PI * Math.Pow(Raio, 2);
            Console.WriteLine("A área do círculo é: " + area);
            return area;
        }

        public double CalcularPerimetro()
        {
            double circunferencia = 2 * Math.PI * Raio;
            Console.WriteLine("A circunferência do círculo é: " + circunferencia);
            return circunferencia;
        }
    }
}
