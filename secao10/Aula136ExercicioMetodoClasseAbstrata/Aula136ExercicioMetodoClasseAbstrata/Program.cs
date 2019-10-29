using System;
using System.Collections;
using System.Collections.Generic;
using Aula136ExercicioMetodoClasseAbstrata.Entities;

namespace Aula136ExercicioMetodoClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            Console.WriteLine("Insira o número de contribuintes:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do contribuinte {i} ");
                Console.Write("Física ou Jurídica (f/j)? ");
                char tipoPessoa = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine());

                if (tipoPessoa == 'f')
                {
                    Console.Write("Despesa com saúde: ");
                    double despesaSaude = double.Parse(Console.ReadLine());
                    listaPessoas.Add(new PessoaFisica(nome, rendaAnual, despesaSaude));
                }
                else
                {
                    Console.Write("Número de colaboradores: ");
                    int quantidadeColaborador = int.Parse(Console.ReadLine());
                    listaPessoas.Add(new PessoaJuridica(nome, rendaAnual, quantidadeColaborador));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Imposto Pago: ");
            double totalImposto = 0;
            foreach (Pessoa pessoa in listaPessoas)
            {
                Console.WriteLine($"{pessoa.Nome}: R$ {pessoa.TaxaImposto()}");
                totalImposto += pessoa.TaxaImposto();
            }
            Console.WriteLine($"Total Impostos: R${totalImposto}");
        }
    }
}
