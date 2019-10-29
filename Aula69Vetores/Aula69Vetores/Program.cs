using System;
using System.Globalization;

namespace Aula69Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXEMPLO 01
            /*int numero = int.Parse(Console.ReadLine());

            double[] vetor = new double[numero];
            double soma = 0.0;

            for (int i = 0; i < numero; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += vetor[i];
            }

            double media = soma / numero;
            Console.WriteLine($"Média = {media}");*/

            //EXEMPLO 02
            int numeroProduto = int.Parse(Console.ReadLine());

            Produto[] vetorProduto = new Produto[numeroProduto];
            double soma = 0.0;
            for (int i = 0; i < numeroProduto; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetorProduto[i] = new Produto { Name = name, Price = price };
                soma += vetorProduto[i].Price;
            }

            double media = soma / numeroProduto;

            Console.WriteLine($"Preço medio = {media.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine(vetorProduto);

            Console.ReadLine();
        }
    }
}
