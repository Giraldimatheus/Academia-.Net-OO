using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_Exercicios
{
    internal class Pessoa
    {
        private string _nome;
        private string _email;
        private Endereco _endereco;
        private int _idade;
        private float _altura;

        public int Idade { get { return _idade; } set { _idade = value; } }
        public float Altura { get { return _altura; } set { _altura = value; } }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
            }
        }
        public Endereco Endereco { get { return _endereco; } set { _endereco = value; } }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Altura: {Altura}";
        }
    }
}
