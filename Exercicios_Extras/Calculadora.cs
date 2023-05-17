using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Extras
{
    internal class Calculadora
    {
        public double Resultado { get; set; }

        public void Somar(double valor1, double valor2)
        {
            this.Resultado = valor1+valor2;
            Console.WriteLine($"O resultado de {valor1} + {valor2} é: " + Resultado);
        }
        public void Subtrair(double valor1, double valor2)
        {
            this.Resultado = valor1-valor2;
            Console.WriteLine($"O resultado de {valor1} - {valor2} é: " + Resultado);
        }
        public void Multiplicar(double valor1, double valor2)
        {
            this.Resultado = valor1* valor2;
            Console.WriteLine($"O resultado de {valor1} x {valor2} é: " + Resultado);
        }
        public void Dividir(double valor1, double valor2)
        {
            this.Resultado = valor1/valor2;
            Console.WriteLine($"O resultado de {valor1} / {valor2} é: " + Resultado);
        }

    }
}
