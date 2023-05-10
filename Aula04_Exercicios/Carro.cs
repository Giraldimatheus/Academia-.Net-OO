using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_Exercicios
{
    internal class Carro
    {
        private string _modelo;
        private int _ano;
        private int _velocidade;

        public string Modelo
        {
            get 
            { 
                return _modelo; 
            } 
            set
            {
                _modelo = value;
            }
        }

        public int Ano
        {
            get 
            { 
                return _ano; 
            }
            set 
            {
                if(value > 1886)
                {
                    _ano= value;
                }
                else
                {
                    Console.WriteLine("Não existe carros antes do ano 1886.");
                   
                }
            }
        }

        public int Velocidade
        {
            get
            {
                return _velocidade;
            }
            set 
            { 
                if(value > 0)
                {
                    _velocidade = value;
                }
                else if(value < 0)
                {
                    Console.WriteLine("Carro já está parado.");
                }
            }
        }

        public void Acelerar(int valor = 10)
        {
            Velocidade += valor;
            Console.WriteLine("Carro acelerou em " + valor +" Kilometros");
        }
        public void Frear(int valor = 10) 
        {
            Velocidade -= valor;
            Console.WriteLine("Carro diminuiu em " + valor + " Kilometros");
        }

    }
}
