using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Exercicios
{
    internal class ContaCorrente
    {
        private double saldo;

        public void DefinirSaldoInicial(double valor)
        {
            if (saldo == 0.0)
            {
                saldo = valor;
            }
        }

        public void Depositar (double valor)
        {
            saldo = valor + saldo;
        }

        public void Sacar (double valor)
        {
            if( valor < saldo)
            {
                saldo = saldo - valor;
                Console.WriteLine("Saque efetuado.");
            }
            else
            {
                Console.WriteLine("Não possui esse saldo.");
            }

        }

        public double GetSaldo()
        {
            return saldo;
        }

    }
}
