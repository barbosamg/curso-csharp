using System;
using System.Collections.Generic;
using System.Text;

namespace Aula136ExercicioMetodoClasseAbstrata.Entities
{
    class PessoaFisica : Pessoa
    {
        public double DespesaSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double despesaSaude) : base(nome, rendaAnual)
        {
            DespesaSaude = despesaSaude;
        }

        public override double TaxaImposto()
        {
            double taxaImposto;
            if (RendaAnual < 20000)
            {
                taxaImposto = RendaAnual * 0.15;
            }
            else
            {
                taxaImposto = RendaAnual * 0.25;
            }
            if (DespesaSaude > 0)
            {
                taxaImposto = taxaImposto - (DespesaSaude * 0.50);
            }
            return taxaImposto;
        }

    }
}
