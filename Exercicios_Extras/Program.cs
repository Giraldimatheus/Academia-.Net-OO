using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Extras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------------------------------------------
            //Exericio 1

            //Retangulo retangulo= new Retangulo();
            //retangulo.Altura = 5.3;
            //retangulo.Largura = 8;

            //retangulo.CacularPerimetro(5.3,8);
            //retangulo.CacularArea();
            //bool quadrado = retangulo.VerificarQuadrado();

            //Console.WriteLine($"Área: {retangulo.Area}");
            //Console.WriteLine($"Perímetro: {retangulo.Perimetro}");
            //Console.WriteLine($"É quadrado? {quadrado}");

            //Console.ReadLine();

            //--------------------------------------------------------------------------------------
            //Exericio 2

            //Console.WriteLine("Bem vindo ao Banco");
            //ContaBancaria conta = new ContaBancaria();
            //conta.Saldo = 1000;
            //while (true)
            //{
            //    Console.WriteLine("Se deseja sacar digite 1, se deseja depositar digite 2, se deseja ver saldo digite 3, sair digite 0.");
            //    int op = int.Parse(Console.ReadLine());
            //    if (op == 0)
            //    {
            //        break;
            //    }
            //    else if (op == 1)
            //    {
            //        Console.WriteLine("Qual valor deseja sacar? ");
            //        double saque = double.Parse(Console.ReadLine());
            //        conta.Sacar(saque);
            //        Console.WriteLine("Saque realizado com Sucesso.");
            //    }
            //    else if (op == 2)
            //    {
            //        Console.WriteLine("Qual valor deseja depositar? ");
            //        double deposito = double.Parse(Console.ReadLine());
            //        conta.Depositar(deposito);
            //        Console.WriteLine("Deposito realizado com sucesso.");
            //    }
            //    else if (op == 3)
            //    {
            //        conta.ConsultarSaldo();
            //    }
            //}

            //--------------------------------------------------------------------------------------
            //Exericio 3

            //Calculadora calculadora = new Calculadora();

            //calculadora.Somar(56, 358);
            //calculadora.Subtrair(10, 50);
            //calculadora.Multiplicar(10, 50);
            //calculadora.Dividir(30, 5);

            //--------------------------------------------------------------------------------------
            //Exericio 4

            //Livraria livraria = new Livraria();

            //// Adicionar livros à livraria
            //livraria.AdicionarLivro("Livro 1", "Autor 1", 29.99);
            //livraria.AdicionarLivro("Livro 2", "Autor 2", 19.99);
            //livraria.AdicionarLivro("Livro 3", "Autor 3", 14.99);

            //// Listar livros na livraria
            //livraria.ListarLivros();

            //// Buscar informações de um livro pelo título
            //string titulo = "Livro 2";
            //string infoLivro = livraria.BuscarLivro(titulo);
            //Console.WriteLine($"Informações do livro '{titulo}': {infoLivro}");

            //// Remover um livro da livraria
            //string tituloRemover = "Livro 1";
            //string autorRemover = "Autor 1";
            //livraria.RemoveLivro(tituloRemover, autorRemover);

            //// Listar livros atualizados na livraria
            //livraria.ListarLivros();

            //// Calcular o valor total dos livros na livraria
            //double valorTotal = livraria.CalcularValorTotal();
            //Console.WriteLine($"Valor total dos livros na livraria: R$ {valorTotal}");

            //Console.ReadLine();

            //--------------------------------------------------------------------------------------
            //Exericio 5

            List<IFormaGeometrica> formas = new List<IFormaGeometrica>();

            Retangulo2 retangulo = new Retangulo2();
            retangulo.Altura = 5;
            retangulo.Largura = 10;
            formas.Add(retangulo);

            Circulo circulo = new Circulo();
            circulo.Raio = 7;
            formas.Add(circulo);

            foreach (IFormaGeometrica forma in formas)
            {
                forma.CalcularArea();
                forma.CalcularPerimetro();
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
