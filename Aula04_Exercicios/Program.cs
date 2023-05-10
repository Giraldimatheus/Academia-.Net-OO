using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pessoa p1 = new Pessoa();
            //p1.Nome = "Matheus";
            //p1.Email = "mat@mat.com";
            ////Console.WriteLine("Nome: "+ p1.nome);
            ////Console.WriteLine("Email: "+ p1.email);
            //p1.Endereco = new Endereco();
            //p1.Endereco.Rua = "Rua";
            //p1.Endereco.Numero = 123;
            //p1.Endereco.Complemento = "Complemento";

            //Pessoa p2 = new Pessoa();
            //p2.Nome = "Amanda";
            //p2.Email = "amanda@amanda.com";
            //p2.Endereco = new Endereco();
            //p2.Endereco.Rua = "Outra rua";
            //p2.Endereco.Numero = 321;
            //p2.Endereco.Complemento = "Complement";

            //List<Pessoa> listaPessoas = new List<Pessoa>();
            //listaPessoas.Add(p1);
            //listaPessoas.Add(p2);

            //foreach(Pessoa pessoa in listaPessoas)
            //{
            //    Console.WriteLine("-------------------------");
            //    Console.WriteLine("Nome: "+pessoa.Nome);
            //    Console.WriteLine("Email: " + pessoa.Email);
            //    Console.WriteLine("Rua: " + pessoa.Endereco.Rua);
            //    Console.WriteLine("Numero: "+pessoa.Endereco.Numero);
            //    Console.WriteLine("Complemento: "+pessoa.Endereco.Complemento);
            //}


            //------------------------------------------------------------------------------------------------------------
            //EXERCICIO 11

            //    Aluno aluno1 = new Aluno();
            //    Console.WriteLine("Vamos calcular a media do Aluno.");
            //    Console.WriteLine("Qual o nome: ");
            //    aluno1.Nome = Console.ReadLine();
            //    Console.WriteLine("Qual o valor da nota 1: ");
            //    aluno1.Nota1 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Qual o valor da nota 2: ");
            //    aluno1.Nota2 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Qual o valor da nota 3: ");
            //    aluno1.Nota3 = double.Parse(Console.ReadLine());

            //    Aluno aluno2 = new Aluno();
            //    Console.WriteLine("Qual o nome: ");
            //    aluno2.Nome = Console.ReadLine();
            //    Console.WriteLine("Qual o valor da nota 1: ");
            //    aluno2.Nota1 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Qual o valor da nota 2: ");
            //    aluno2.Nota2 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Qual o valor da nota 3: ");
            //    aluno2.Nota3 = double.Parse(Console.ReadLine());

            //    List<Aluno> listaalunos = new List<Aluno>();
            //    listaalunos.Add(aluno1);
            //    listaalunos.Add(aluno2);

            //    foreach(Aluno aluno in listaalunos)
            //    {
            //        Console.WriteLine("-------------------------");
            //        Console.WriteLine("Nome: " + aluno.Nome);
            //        Console.WriteLine("Nota 1: "+aluno.Nota1);
            //        Console.WriteLine("Nota 2: "+aluno.Nota2);
            //        Console.WriteLine("Nota 3: "+aluno.Nota3);
            //        aluno.CalcularMedia(); 
            //        Console.WriteLine("Média: " + aluno.Media);
            //        if (aluno.Media > 60)
            //        {
            //            Console.WriteLine("Aprovado.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Reprovado.");
            //        }
            //    }
            //}

            //    //Console.WriteLine($"Nome: {aluno1.Nome}\nMedia: {aluno1.Media}");


            //------------------------------------------------------------------------------------------------------------
            //EXERCICIO 12

            //Carro carro = new Carro();
            //Console.WriteLine("Qual o modelo do carro? ");
            //carro.Modelo = Console.ReadLine();
            //Console.WriteLine("Qual o ano do carro? ");
            //carro.Ano = int.Parse(Console.ReadLine());
            //Console.WriteLine("Qual a velocidade do carro? ");
            //carro.Velocidade = int.Parse(Console.ReadLine());
            //while(true)
            //{
            //    Console.WriteLine("Se deseja acelerar o carro aperte 1, se deseja frear 2");
            //    int op = int.Parse(Console.ReadLine());
            //    if(op == 1)
            //    {
            //        carro.Acelerar();
            //        Console.WriteLine("Velocidade atual: " + carro.Velocidade);
            //    }
            //    else if (op == 2)
            //    {
            //        carro.Frear();
            //        Console.WriteLine("Velocidade atual: " + carro.Velocidade);
            //    }
            //}

            //------------------------------------------------------------------------------------------------------------
            //EXERCICIO 13

            //Livro livro = new Livro();
            //livro.Autor = new Autor();
            //livro.Autor.Nome = "Astolfo";
            //livro.Autor.Idade = 93;
            //livro.Titulo = "Titulo legal";
            //Console.WriteLine(livro.ToString());

            //------------------------------------------------------------------------------------------------------------
            //EXERCICIO 14

            Agenda agenda = new Agenda();
            agenda.ArmazenaPessoa("João", 25, 1.85f);
            agenda.ArmazenaPessoa("Maria", 30, 1.65f);
            agenda.ArmazenaPessoa("Pedro", 40, 1.75f);
            agenda.ArmazenaPessoa("Lucas", 20, 1.70f);
            agenda.ArmazenaPessoa("Mariana", 27, 1.68f);
            agenda.ArmazenaPessoa("Roberto", 45, 1.80f);
            agenda.ArmazenaPessoa("Ana", 22, 1.72f);
            agenda.ArmazenaPessoa("Fernando", 37, 1.77f);
            agenda.ArmazenaPessoa("Carla", 29, 1.73f);
            agenda.ArmazenaPessoa("Henrique", 33, 1.78f);
            agenda.ImprimeAgenda();
            agenda.RemovePessoa("Roberto");
            agenda.ImprimeAgenda();
            agenda.BuscaPessoa("Carla");
            agenda.LimpaAgenda();





        }
    }
}
