using System;
using System.Globalization;

namespace SobrecargaAula52
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Produto produto = new Produto(nome, preco);

            Produto p2 = new Produto();

            Produto p3 = new Produto { Nome = "Espelho", Preco = 100.00, Quantidade = 50 };

            Console.WriteLine($"Dados do produto: {produto}");

            Console.Write("Digite o número de produtos a ser adicionados no estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qtd);

            Console.WriteLine($"Dados do atualizados com adição: {produto}");

            Console.Write("Digite o número de produtos a ser removidos no estoque: ");
            qtd = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qtd);

            Console.WriteLine($"Dados do atualizados com remoção: {produto}");

            Console.ReadKey();
        }
    }
}
