using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Extras
{
    internal class Livraria
    {
        private List<Livro> livros;

        public Livraria()
        {
            livros = new List<Livro>();
        }
        
        public void AdicionarLivro(string titulo, string autor, double preco)
        {
            Livro livro = new Livro();
            {
                livro.Nome = titulo;
                livro.Autor = autor;
                livro.Preco= preco;
            };

            livros.Add(livro);
        }
        public void RemoveLivro(string titulo, string autor)
        {
            Livro livro = livros.FirstOrDefault(l => l.Nome == titulo && l.Autor == autor);
            if (livro != null)
            {
                livros.Remove(livro);
            }
            else
            {
                Console.WriteLine("Digite o nome e autor corretamente.");
            }
        }
        public string BuscarLivro(string titulo)
        {
            Livro livro = livros.FirstOrDefault(l => l.Nome == titulo);

            if (livro != null)
            {
                return $"Autor: {livro.Autor}, Preço: R$ {livro.Preco}";
            }

            return "Livro não encontrado";
        }
        public void ListarLivros()
        {
            Console.WriteLine("Livros na livraria:");

            foreach (Livro livro in livros)
            {
                Console.WriteLine($"- {livro.Nome}, de {livro.Autor} | Preço: R$ {livro.Preco}");
            }
        }
        public double CalcularValorTotal()
        {
            double valorTotal = 0;

            foreach (Livro livro in livros)
            {
                valorTotal += livro.Preco;
            }

            return valorTotal;
        }


    }
}
