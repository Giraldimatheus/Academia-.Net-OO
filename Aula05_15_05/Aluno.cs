using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_15_05
{
    internal class Aluno : Pessoa
    {
        public int Matricula { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}\nMatricula: {Matricula}");
        }

    }
}
