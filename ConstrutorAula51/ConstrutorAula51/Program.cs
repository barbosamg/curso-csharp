using System;
using System.Globalization;

namespace ConstrutorAula51
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

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);

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
