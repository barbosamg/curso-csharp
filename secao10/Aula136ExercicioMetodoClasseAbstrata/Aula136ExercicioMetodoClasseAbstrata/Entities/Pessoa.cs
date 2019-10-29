using System;
using System.Collections.Generic;
using System.Text;

namespace Aula136ExercicioMetodoClasseAbstrata.Entities
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        protected Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        abstract public double TaxaImposto();
    }
}
