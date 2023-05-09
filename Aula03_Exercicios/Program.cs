using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Aula03_Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //EXERCICIO 1

            //Console.WriteLine("Se deseja informar Nome e Idade, digite 1, se apenas Idade, digite 2: ");
            //int op = int.Parse(Console.ReadLine());

            //if (op == 1)
            //{
            //    Console.WriteLine("Digite o nome: ");
            //    string nome = Console.ReadLine();
            //    Console.WriteLine("Digite a idade: ");
            //    int idade = int.Parse(Console.ReadLine());

            //    Pessoa p = new Pessoa(nome, idade);

            //    Console.WriteLine($"Nome: {p.Nome} e a idade: {p.Idade}");
            //}
            //else if (op == 2)
            //{

            //    Console.WriteLine("Digite a idade: ");
            //    int idade = int.Parse(Console.ReadLine());

            //    Pessoa p = new Pessoa(idade);

            //    Console.WriteLine($"Idade: {p.Idade}");
            //}


            //------------------------------------------------------------------------------------------------------------
            //EXERCICIO 2

            //Aluno aluno = new Aluno();

            //aluno.Pessoa = new Pessoa();
            //aluno.Pessoa.Nome = "João";
            //aluno.matricula = "12365";

            //Aluno aluno2= new Aluno();
            //aluno2.date = "15/05/2000"; 

            //Aluno aluno3 = new Aluno();
            //aluno3.Pessoa = new Pessoa();
            //aluno3.Pessoa.Nome = "Astolfo";
            //aluno3.date = "20/10/1965";
            //aluno3.anoMatricula = "2023";

            //Console.WriteLine("Aluno 1: ");
            //Console.WriteLine(aluno.Pessoa.Nome);
            //Console.WriteLine(aluno.matricula);
            //Console.ReadLine();

            //Console.WriteLine("Aluno 2: ");
            //Console.WriteLine(aluno2.date);
            //Console.ReadLine();

            //Console.WriteLine("Aluno 3: ");
            //Console.WriteLine(aluno3.Pessoa.Nome);
            //Console.WriteLine(aluno3.date);
            //Console.WriteLine(aluno3.anoMatricula);

            //Console.ReadLine();

            //------------------------------------------------------------------------------------------------------------
            //EXERCICIO 3

            //ContaCorrente contaCorrente = new ContaCorrente();

            //Console.WriteLine("Para criar sua conta, digite 1, se deseja sair, digite 0");
            //int op = int.Parse(Console.ReadLine());

            //if (op == 0)
            //{
            //    return;
            //}
            //if (op == 1)
            //{
            //    Console.WriteLine("Definir saldo da conta: ");
            //    double saldoInicial = double.Parse(Console.ReadLine());
            //    contaCorrente.DefinirSaldoInicial(saldoInicial);
            //}

            //while (true)
            //{
            //    Console.WriteLine("Se quiser fazer um saque digite 1, se quiser depositar digite 2, ou apenas ver saldo digite 3. Se desaja sair digite 0: ");
            //    int op2 = int.Parse(Console.ReadLine());
            //    if (op2 == 1)
            //    {
            //        Console.WriteLine("Qual valor deseja sacar? ");
            //        double saque = double.Parse(Console.ReadLine());

            //        contaCorrente.Sacar(saque);
            //    }
            //    else if (op2 == 2)
            //    {
            //        Console.WriteLine("Qual valor deseja depositar? ");
            //        double deposito = double.Parse(Console.ReadLine());

            //        contaCorrente.Depositar(deposito);
            //    }
            //    else if (op2 == 3)
            //    {
            //        Console.WriteLine($"Seu saldo é de {contaCorrente.GetSaldo()}");
            //    }
            //    else if (op2 == 0)
            //    {
            //        break;
            //    }
            //}

            //------------------------------------------------------------------------------------------------------------
            //EXERCICIO 4

            //Console.WriteLine("Digite o nome: ");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Digite a idade: ");
            //int idade = int.Parse(Console.ReadLine());

            //Pessoa p = new Pessoa();

            //p.SetNome(nome);
            //p.SetIdade(idade);

            //------------------------------------------------------------------------------------------------------------
            //EXERCICIO 5

            //Console.WriteLine("Digite o saldo: ");
            //int saldo = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o limite: ");
            //double limite = int.Parse(Console.ReadLine());

            //Conta conta = new Conta();

            //conta.GetNumero();
            //conta.SetSaldo(saldo);
            //conta.SetLimite(limite);

            //Console.WriteLine("Número: " + conta.GetNumero());
            //Console.WriteLine("Saldo: "+ conta.GetSaldo());
            //Console.WriteLine("limite: "+ conta.GetLimite());

            //------------------------------------------------------------------------------------------------------------
            //EXERCICIO 6

            //Produto produto = new Produto();
            //produto.nome = "Computador";
            //produto.fabricante = new Fabricante();
            //produto.fabricante.SetNome("Dell");
            //produto.fabricante.cidade = "Londrina-PR";
            //produto.fabricante.endereco = "Rua rua 1234";
            //produto.SetPreco(2500.00);

            //Console.WriteLine("Informações do produto: ");
            //Console.WriteLine(produto);

            //------------------------------------------------------------------------------------------------------------
            //EXERCICIO 7

            //Livro livro = new Livro();
            //livro.autor = new Autor();
            //livro.autor.SetNome("Astolfo");
            //livro.SetTitulo("titulo legal");
            //Console.WriteLine(livro);

            //------------------------------------------------------------------------------------------------------------
            //EXERCICIO 8

            //Aluno aluno = new Aluno();
            //aluno.Pessoa = new Pessoa();
            //aluno.Pessoa.SetNome("Astolfo");
            //aluno.SetMatricula(10);

            //aluno.ExibirInformacoes();

            //------------------------------------------------------------------------------------------------------------
            //EXERCICIO 9

            ContaBancaria conta = new ContaBancaria();
            conta.Titular = "Astolfo";
            conta.NumeroConta = 12345-6;
            conta.Saldo = 2500.00;
            conta.Limite = 1000.00;

            Console.WriteLine("Bem vindo a sua conta Sr: " + conta.Titular + " Número da conta: " + conta.NumeroConta);
            while (true)
            {
                Console.WriteLine("Digite 1 para Deposito, 2 para Saque e 3 para Saldo ou 0 para sair");
                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("Qual valor deseja depositar?");
                    double valor = double.Parse(Console.ReadLine());
                    conta.Depositar(valor);
                    Console.WriteLine("Seu novo saldo é de: " + conta.Saldo);
                }
                if (op == 2)
                {
                    Console.WriteLine("Qual valor deseja sacar? ");
                    double saque = double.Parse(Console.ReadLine());
                    conta.Sacar(saque);
                    Console.WriteLine("Seu novo saldo é de: " + conta.Saldo);
                }
                if (op == 3)
                {
                    Console.WriteLine("Seu saldo é de: " + conta.Saldo);
                }
                if (op == 0)
                {
                    break;
                }
            }

            //------------------------------------------------------------------------------------------------------------
            //EXERCICIO 10

            //Animal animal = new Animal();
            //animal.nome = "Astolfo";
            //animal.especie = "Cachorro";
            //animal.EmitirSom("auau");

            //Console.WriteLine(animal);

        }
    }
}
