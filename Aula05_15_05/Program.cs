using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_15_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Veiculo v = new Veiculo();
            //v._potencia = 500;
            //v._modelo = "Gol";
            //v.Dirigir();

            //Carro carro = new Carro();
            //carro._marca = "VW";
            //carro._modelo = "fusca";
            //carro.QtdeDePorta = 2;
            
            //Motocicleta moto = new Motocicleta();
            //moto._marca = "Ducatti";
            //moto._modelo = "Scrambler";
            //moto.Cilindradas = 803;

            Circulo circulo = new Circulo(33);
            double perimetro = circulo.CalcularPerimetro();
            double area = circulo.CalcularArea();

            Retangulo retangulo = new Retangulo(37, 13);
            double PerimetroR = retangulo.CalcularPerimetro();
            double areaR  =retangulo.CalcularArea();

            Console.WriteLine("Área do círculo: " + area);
            Console.WriteLine("Perímetro do círculo: " + perimetro);

            Console.WriteLine("Área do Retangulo: " + areaR);
            Console.WriteLine("Perímetro do Retangulo: " + PerimetroR);



        }
    }
}
