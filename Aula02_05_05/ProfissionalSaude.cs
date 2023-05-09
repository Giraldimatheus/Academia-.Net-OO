using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02_05_05
{
    internal class ProfissionalSaude
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string RegistroConselho { get; set; }

        public ProfissionalSaude(string nome, string tipo, string registroConselho)
        {
            Nome = nome.ToUpper();
            Tipo = tipo.ToUpper();
            RegistroConselho = registroConselho.ToUpper();
        }

        public string Sobrenome()
        {
            string[] Lista = Nome.Split();
            return Lista[Lista.Length - 1] + " - " + RegistroConselho;
        }

        public ProfissionalSaude() { }

    }




}
