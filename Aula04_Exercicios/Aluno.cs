using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_Exercicios
{
    internal class Aluno
    {
        private string _nome;
        private double _nota1;
        private double _nota2;
        private double _nota3;
        private double _media;

        public string Nome { get { return _nome;} set { _nome = value; } }
        public double Nota1 { get { return _nota1;} 
            set 
            { 
                if(value >= 0)
                {
                    _nota1 = value;
                }
                else
                {
                    Console.WriteLine("Nota não pode ser menor que zero.");
                }
            } 
        }
        public double Nota2 { get { return _nota2;} 
            set 
            {
                if (value >= 0)
                {
                    _nota2 = value;
                }
                else
                {
                    Console.WriteLine("Nota não pode ser menor que zero.");
                }
            } 
        }
        public double Nota3 { get { return _nota3;}
            set
            {
                if (value >= 0)
                {
                    _nota3 = value;
                }
                else
                {
                    Console.WriteLine("Nota não pode ser menor que zero.");
                }
            }
        }
        public double Media { get { return _media;} set { _media = value; } }

        public void CalcularMedia()
        {
            Media = (Nota1 + Nota2 + Nota3) / 3;
        }

    }
}
