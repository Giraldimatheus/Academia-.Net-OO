using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Net_OrientacaoObjetos
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set;}
        public void exibeDados()
        {
            Console.WriteLine("Nome: "+this.Nome);
            Console.WriteLine("Idade: " + this.Idade);
        }
        public void exibeDadosIdade()
        {
            Console.WriteLine("Idade " + this.Idade);
        }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
        public Pessoa(int idade)
        {
            this.Idade = idade;
        }
        public Pessoa()
        {

        }
    }
}
