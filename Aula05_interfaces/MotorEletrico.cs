using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_interfaces
{
    internal class MotorEletrico : IMotor
    {
        public double CorrenteEletrica;
        public bool ligado;
        public void Desligar()
        {
            if (ligado)
            {
                ligado = false;
            }
            Console.WriteLine("Motor Eletrico desligado");
        }

        public void Ligar()
        {
            if (CorrenteEletrica > 0 && !ligado)
            {
                ligado = true;
            }
            Console.WriteLine("Motor Eletrico ligado");
        }
    }
}
