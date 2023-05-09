using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_08_05
{
    internal class Motor
    {
        private int cilindradas;
        private bool ligado;

        public int Cilindradas { get { return cilindradas; } set { cilindradas = value; } }

        public bool Ligado { get { return ligado;} set { } }


        public void LigarMotor()
        {
            Ligado = true;
        }
        public void DesligarMotor()
        {
            Ligado = false;
        }


    }
}
