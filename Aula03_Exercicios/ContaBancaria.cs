using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Exercicios
{
    internal class ContaBancaria
    {
        private int _numeroConta;
        private string _titular;
        private double _saldo;
        private double _limite;

        public int NumeroConta { get { return _numeroConta; } set { _numeroConta = value; } }
        public string Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _titular = value;
                }
            }
        }
        public double Saldo { get { return _saldo; } set { _saldo = value; } }
        public double Limite
        {
            get
            {
                return _limite;
            }
            set
            {
                if(value > 0)
                {
                    _limite = value;
                }
                
            }
        }


        public void Depositar(double deposito)
        {
            if (deposito > 0)
            {
                this.Saldo = Saldo + deposito;
            }
            else
            {
                Console.WriteLine("Deposito precisa ser maior que 0.");
            }

        }
        public void Sacar(double saque)
        {
            if ((Saldo + Limite) >= saque)
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
