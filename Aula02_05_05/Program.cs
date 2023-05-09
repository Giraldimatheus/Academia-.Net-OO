using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Aula02_05_05
{
    internal class Program
    {
        static void Main(string[] args)
        {


            UnidadeSaude us1 = new UnidadeSaude("Unidade são Jose", "USJ");


            us1.Responsavel.Nome = "Alexandre Zamberlan";
            us1.Responsavel.Tipo = "enfermeiro";
            us1.Responsavel.RegistroConselho = "TEC123";

            Paciente Pc1 = new Paciente("lEANDRO", "9884218482", DateTime.Parse("08/09/1974"), "laza@ufn.com.br");

            ProfissionalSaude resp1 = new ProfissionalSaude("Daniela Rodrigues", "Enfermeiro", "Enf1234");

            Triagem t1 = new Triagem(resp1, Pc1, 88, 188, 122, 38, "Amarelo");

            Console.WriteLine("unidade: " + us1.Nome);
            Console.WriteLine("responsavel: " + us1.Responsavel.Nome);

            DateTime dateTime = new DateTime();
            dateTime = dateTime.ToLocalTime();





        }


    }


}