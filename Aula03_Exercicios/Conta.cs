using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Exercicios
{
    internal class Conta
    {
        private readonly string numero = "123456";
        private double saldo;
        private double limite;

        public string GetNumero()
        {
            return numero;
        }
        public void SetSaldo(double saldo)
        {
            if(saldo < 0)
            {
                Console.WriteLine("Saldo não pode ser menor que 0");
            }
            else
            {
                this.saldo = saldo;
            }
        }
        public double GetSaldo()
        {
            return this.saldo;
        }

        public double GetLimite()
        {
            return this.limite;
        }
        public void SetLimite(double limite)
        {
            if(limite < 0) 
            {
                Console.WriteLine("Limite não pode ser negativo");
            }
            else
            {
                this.limite = limite;
            }
        }

    }

}
