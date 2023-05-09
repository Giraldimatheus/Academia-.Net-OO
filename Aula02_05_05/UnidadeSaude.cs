using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02_05_05
{
    internal class UnidadeSaude
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public ProfissionalSaude Responsavel { get; set; } 

        public UnidadeSaude()
        {
            Responsavel = new ProfissionalSaude();
        }
        public UnidadeSaude(string nome, string sigla)
        {
            Nome = nome.ToUpper();
            Sigla = sigla.ToUpper();
            Responsavel = new ProfissionalSaude();
        }
        public UnidadeSaude(string nome)
        {
            Nome = nome;
            Responsavel = new ProfissionalSaude();
        }


    }
}
