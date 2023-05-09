using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Exercicios
{
    internal class Pessoa
    {
        private string nome;
        private int idade;

        public string Nome { get { return nome; } set { nome = value; } }

        public int Idade { get { return idade; } set { idade = value; } }

        public void SetNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("O nome não pode ser vazio.");
            }
            this.Nome = nome;
        }

        public void SetIdade (int idade)
        {
            if(idade < 0)
            {
                Console.WriteLine("Idade não pode ser menor que 0.");
            }
            else
            {
                this.Idade= idade;
            }
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
        public Pessoa(string nome)
        {
            this.Nome = nome;
        }
        public Pessoa()
        {
            
        }

        public override string ToString()
        {
            return $"Nome: {nome}\n Idade: {idade}";
        }

    }


}
