using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_interfaces
{

    internal class MotorCombustao : IMotor
    {
        public double QtdeGasolina;
        public bool ligado;


        public void Desligar()
        {
            if (ligado)
            {
                ligado= false;
            }
            Console.WriteLine("Motor Combustao desligado");
        }

        public void Ligar()
        {
            if(QtdeGasolina > 0)
            {
                ligado = true;
            }
            Console.WriteLine("Motor Combustao ligado");
        }
    }
}
