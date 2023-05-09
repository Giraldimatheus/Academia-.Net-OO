using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Exercicios
{
    internal class Fabricante
    {
        private string nome;
        public string endereco { get; set; }
        public string cidade { get; set; }

        public string GetNome()
        {
            return nome;
        }
        public void SetNome(string nome)
        {
            if (nome == null)
            {
                Console.WriteLine("Nome não pode ser vazio.");
            }
            else
            {
                this.nome = nome;
            }
        }

        public override string ToString()
        {
            return $"Nome: {nome}\nEndereço: {endereco}\nCidade: {cidade}";
        }
    }
}
