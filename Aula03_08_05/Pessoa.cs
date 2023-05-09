using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_08_05
{
    internal class Pessoa
    {
        /*Encapsulamento é um principio da orientaçao a objetos
         * Permite proteger informações de um objeto*/

        //public -> vao ser publico, vai ser visivel a todos os componentes do programa
        //protected -> é acessivel dentro da propria classe e na suas subclasses (herança)
        //private -> é acessivel somente dentro da classe
        //internal -> podem ser acessados dentro do mesmo assemble (um conjunto de arquivos de codigos fontes que são compilados juntos)

        private string nome { get; set; }
        private int idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            Console.WriteLine("Nome: " + nome + " Idade: " + idade);
        }
        public Pessoa(int idade)
        {
            this.idade = idade;
            Console.WriteLine("Idade: " + idade); 
        }
        public Pessoa()
        {

        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }




    }
}
