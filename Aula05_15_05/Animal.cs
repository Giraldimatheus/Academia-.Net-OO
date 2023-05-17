﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_15_05
{
    internal abstract class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
                
        }

        public abstract void EmitirSom();

    }
}