using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Net_OrientacaoObjetos
{
    internal class Computador
    {
        public string Marca { get; set; }
        public string Modelo { get; set;}
        public string Tipo { get;set;}
        public double Preco { get; set;}

        public void exibeDados()
        {
            Console.WriteLine("Marca " + this.Marca);
            Console.WriteLine("Modelo " + this.Modelo);
            Console.WriteLine("Tipo " + this.Tipo);
            Console.WriteLine("Preco "+this.Preco);

        }

        public Computador(string marca, string modelo, string tipo, double preco)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Tipo = tipo;
            this.Preco = preco;
        }

        public Computador()
        {
        }
    }
}
