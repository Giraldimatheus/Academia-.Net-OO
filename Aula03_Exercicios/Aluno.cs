using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Exercicios
{
    internal class Aluno
    {
        public Pessoa Pessoa;

        public string date { get; set; }
        private int matricula { get; set; }
        public string anoMatricula { get; set; }

        public int GetMatricula()
        {
            return matricula;
        }
        public void SetMatricula(int matricula)
        {
            if(matricula > 0)
            {
                this.matricula = matricula;
            }
            else
            {
                Console.WriteLine("Matricula não pode ser menor que 0.");
            }
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Pessoa.Nome}\nMatricula: {matricula}");
        }

        public Aluno(string nome, string date, int SetMatricula, string anoMatricula)
        {
            this.Pessoa = new Pessoa (nome);
            this.date = date;
            this.matricula = SetMatricula;
            this.anoMatricula = anoMatricula;
        }

        public Aluno(string date)
        {
            this.date = date;
        }

        public Aluno()
        {
        }
    }
}
