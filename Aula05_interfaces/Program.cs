using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMotor motor;

            Console.WriteLine("Digite 1 para ME e 2 para MC");
            int op = int.Parse(Console.ReadLine());
            if (op == 1) 
            {
                motor = new MotorEletrico();
                motor.Ligar();
                motor.Desligar();
            }
            else if (op == 2)
            {
                motor = new MotorCombustao();
                motor.Ligar();
                motor.Desligar();
            }
        }
    }
}
