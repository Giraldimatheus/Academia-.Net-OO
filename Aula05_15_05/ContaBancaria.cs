using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_15_05
{
    public abstract class ContaBancaria
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double TaxaJuros { get; set; }
    }
}
