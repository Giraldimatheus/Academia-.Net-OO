using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Extras
{
    internal class ContaBancaria
    {
        private int _numeroConta;
        public string NomeTitular { get; set; }
        public double Saldo { get; set; }

        public int NumeroConta
        {
            get
            {
                return _numeroConta;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Número da conta não pode ser negativo.");
                }

                _numeroConta = value;
            }
        } 
        
        public void Depositar(double deposito)
        {
            if (deposito > 0)
            {
                this.Saldo = Saldo + deposito;
                Console.WriteLine("Seu novo saldo é de: "+Saldo + " Reais.");
            }
            else
            {
                throw new ArgumentException("Deposito não pode ser menor que 0.");
            }
        }
        public void Sacar(double saque)
        {
            if (Saldo > 0)
            {
                this.Saldo = Saldo - saque;
                Console.WriteLine("Seu novo saldo é de: " + Saldo + " Reais.");
            }
        }
        public void ConsultarSaldo()
        {
            Console.WriteLine("Seu saldo é de " + Saldo + " Reais.");
        }
    }
}
