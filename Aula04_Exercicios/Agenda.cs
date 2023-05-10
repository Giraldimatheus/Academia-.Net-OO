using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_Exercicios
{
    internal class Agenda
    {
        private List<Pessoa>_pessoas = new List<Pessoa>();

        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = nome;
            pessoa.Idade = idade;
            pessoa.Altura = altura;

            _pessoas.Add(pessoa);
        }
        public void RemovePessoa(string nome)
        {
            Pessoa pessoa = _pessoas.Find(p => p.Nome == nome);
            if (pessoa != null)
            {
                _pessoas.Remove(pessoa);

                Console.WriteLine("Remover pessoa: ");
                Console.WriteLine($"Pessoa {nome} removida com sucesso.");
                Console.WriteLine("-------------------------------------------");
            }
            else
            {
                Console.WriteLine("Remover pessoa: ");
                Console.WriteLine($"Pessoa {nome} não encontrada na agenda.");
                Console.WriteLine("-------------------------------------------");
            }
        }
        public void BuscaPessoa(string nome)
        {
            foreach(Pessoa pessoa in _pessoas)
            {
                if(pessoa.Nome == nome)
                {
                    Console.WriteLine("Busca especifica: ");
                    Console.WriteLine(pessoa);
                    Console.WriteLine("-------------------------------------------");
                    break;
                }
            }
        }
        public void ImprimeAgenda()
        {
            foreach(Pessoa pessoa in _pessoas)
            {
                Console.WriteLine(pessoa);
                Console.WriteLine("-------------------------------------------");
            }
        }
        public void LimpaAgenda()
        {
            _pessoas.Clear();
        }





    }
}
