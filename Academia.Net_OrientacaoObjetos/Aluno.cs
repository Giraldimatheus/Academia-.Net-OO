using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Net_OrientacaoObjetos
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public int DataNascimento { get; set; }
        public int EntrouFaculdade { get; set; }

        public Aluno(string nome, int matricula)
        {
            this.Nome = nome;
            this.Matricula = matricula;
        }
        public Aluno(int dataNascimento)
        {
            DataNascimento = dataNascimento;

        }
        public Aluno(string nome, int matricula, int dataNascimento, int entrouFaculdade) 
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.EntrouFaculdade = entrouFaculdade;
        }

        public void exibeDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Matricula: "+this.Matricula);
        }
        public void exibeDadosData()
        {
            Console.WriteLine("Data de nascimento: "+this.DataNascimento);
        }
        public void exibeDados2()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Data de nascimento: "+ this.DataNascimento);
            Console.WriteLine("Data que entrou na faculdade: " + this.EntrouFaculdade) ;
        }
    }


}
