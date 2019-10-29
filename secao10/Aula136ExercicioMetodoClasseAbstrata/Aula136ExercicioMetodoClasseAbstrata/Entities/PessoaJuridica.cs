using System;
using System.Collections.Generic;
using System.Text;

namespace Aula136ExercicioMetodoClasseAbstrata.Entities
{
    class PessoaJuridica: Pessoa
    {
        public int QuantidadeFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int quantidadeFuncionarios) : base(nome, rendaAnual)
        {
            QuantidadeFuncionarios = quantidadeFuncionarios;
        }

        public override double TaxaImposto()
        {
            double taxaImposto = 0;
            if(QuantidadeFuncionarios > 10)
            {
                taxaImposto = RendaAnual * 0.14;
            }
            else
            {
                taxaImposto = RendaAnual * 0.16;
            }
            return taxaImposto;
        }
    }
}
