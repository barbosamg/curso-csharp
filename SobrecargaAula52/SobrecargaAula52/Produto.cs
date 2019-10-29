using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace SobrecargaAula52
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public override string ToString()
        {
            return $"{Nome}, R${Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades," +
                    $" Total: ${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int pQuantidade)
        {
            Quantidade = Quantidade + pQuantidade;
        }

        public void RemoverProdutos(int pQuantidade)
        {
            Quantidade -= pQuantidade;
        }
    }
}
