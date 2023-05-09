using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Exercicios
{
    internal class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }

        public void Depositar(double deposito)
        {
            this.Saldo = Saldo + deposito;
        }
        public void Sacar(double saque)
        {
            if(Saldo > saque)
            {
                Saldo = Saldo - saque;
                Console.WriteLine("Saque realizado.");
            }
            else
            {
                Console.WriteLine("Saque não pode ser efetuado, pois não há saldo suficiente.");
            }
        }

    }
}
