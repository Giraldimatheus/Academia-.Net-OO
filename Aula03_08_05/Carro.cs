using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_08_05
{
    internal class Carro
    {
        private string marca;
        private string modelo;
        private int ano;
        private Motor m;

        public string Marca { get { return marca; } set { marca = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }
        public int Ano { get { return ano; } set { ano = value; } }
        public Motor Motor { get { return m; } set { m = value;} }

        public void LigarCarro()
        {
            if(!m.Ligado)
            {
                m.LigarMotor();
                Console.WriteLine("O carro ligou");
            }
            else
            {
                Console.WriteLine("o carro está ligado");
            }
        }
        public void DesligarCarro()
        {
            if (m.Ligado)
            {
                m.DesligarMotor();
                Console.WriteLine("O carro desligou");
            }
            else { Console.WriteLine("O carro já está desligado"); }
        }


    }
}
