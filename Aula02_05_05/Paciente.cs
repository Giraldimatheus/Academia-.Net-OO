using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Aula02_05_05
{
    internal class Paciente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }

        public string Email { get; set; }

        public Paciente(string nome, string cPF, DateTime dataNascimento, string email)
        {
            Nome = nome;
            CPF = cPF;
            DataNascimento = dataNascimento;
            Email = email;
        }

        public Paciente()
        {
          
        }

        public Paciente(string nome, string cPF, DateTime dataNascimento)
        {
            Nome = nome;
            CPF = cPF;
            DataNascimento = dataNascimento;
        }

        public int Idade()
        {
            return DateTime.Now.Year - DataNascimento.Year;
        }

    }


}
