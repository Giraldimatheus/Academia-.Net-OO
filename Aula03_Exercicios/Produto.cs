using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Exercicios
{
    internal class Produto
    {
        public string nome { get; set; }
        public Fabricante fabricante { get; set; }

        private double preco;

        public void SetPreco(double preco)
        {
            if (preco <= 0)
            {
                Console.WriteLine("Preço não pode ser negativo, ou zero.");
            }
            else
            {
                this.preco = preco;
            }
            
        }
        public double GetPreco()
        {
            return preco;
        }

        public override string ToString()
        {
            return $"Nome: {nome}\nPreço: {preco}\nFabricante: {fabricante}";
        }


    }
}
