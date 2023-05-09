using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02_05_05
{
    internal class Triagem
    {
        public ProfissionalSaude Responsavel { get; set; }
        public Paciente Paciente { get; set; }
        public float Peso { get; set; }
        public float Altura { get;set; }
        public float PressaoArterial { get; set;}
        public float Temperatura { get; set; }
        public string Urgencia { get; set; }

        public Triagem(ProfissionalSaude responsavel, Paciente paciente, float peso, float altura, float pressaoArterial, float temperatura, string urgencia)
        {
            Responsavel = responsavel;
            Paciente = paciente;
            Peso = peso;
            Altura = altura;
            PressaoArterial = pressaoArterial;
            Temperatura = temperatura;
            Urgencia = urgencia;
        }

       
    }
}
