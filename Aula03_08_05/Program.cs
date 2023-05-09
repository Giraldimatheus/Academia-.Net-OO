using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_08_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Deseja instanciar a Pessoa com Nome e Idade, ou apenas Idade? Digite 1 ou 2: ");
            //int op = int.Parse(Console.ReadLine());
            //int idade;
            //string nome;
            //Pessoa p;
            //if (op == 1) 
            //{
            //    Console.WriteLine("Digite o nome: ");
            //    nome = Console.ReadLine();
            //    Console.WriteLine("Digite a idade: ");
            //    idade = int.Parse(Console.ReadLine());
            //    p = new Pessoa(nome, idade);
            //}
            //else if (op == 2)
            //{
            //    Console.WriteLine("Digite a idade: ");
            //    idade = int.Parse(Console.ReadLine());

            //}

            //Console.WriteLine("Digite o nome e a idade: ");
            //nome = Console.ReadLine();
            //idade= int.Parse(Console.ReadLine());
            //p = new Pessoa(nome, idade);
            //p.nome = "Astolfo";
            //Console.WriteLine($"Nome: {nome}");

            //Pessoa p;
            //p = new Pessoa();
            //Console.WriteLine("Digite o nome: ");
            //string nome = Console.ReadLine();
            //p.Nome = nome;

            //string nomeRetornado;
            //nomeRetornado = p.Nome();
            //Console.WriteLine("Nome: "+ nomeRetornado);

            Carro c = new Carro();
            c.Marca = "VW";
            c.Ano = 1999;
            c.Modelo = "Gol";
            c.Motor = new Motor();
            c.Motor.Cilindradas = 1500;

            while (true)
            {
                Console.WriteLine("Digite 1 para ligar e 2 para desligar: ");
                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    c.LigarCarro();
                }
                else if (op == 2)
                {
                    c.DesligarCarro();
                }
                else if (op == 0)
                {
                    break;
                }
            }



        }
    }
}
