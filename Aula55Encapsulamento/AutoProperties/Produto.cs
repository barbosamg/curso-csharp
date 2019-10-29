using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConstrutorAula51
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {

        }

        public Produto(string pNome, double pPreco, int pQuantidade)
        {
            _nome = pNome;
            Preco = pPreco;
            Quantidade = pQuantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{_nome}, R${Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades," +
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
