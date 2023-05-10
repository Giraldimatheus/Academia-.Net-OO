using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_Exercicios
{
    internal class Autor
    {
        private string _nome;
        private int _idade;

        public string Nome 
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int Idade
        {
            get { return _idade; }
            set 
            { 
                if(value > 0)
                {
                    _idade = value;
                }
                else
                {
                    Console.WriteLine("Não existe autor com idade negativa.");
                }
            }

        }

        public override string ToString()
        {
            return $"{Nome} \nIdade: {Idade} anos";
        }

    }
}
