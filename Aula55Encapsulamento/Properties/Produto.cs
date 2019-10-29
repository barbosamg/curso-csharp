using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConstrutorAula51
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {

        }

        public Produto(string pNome, double pPreco, int pQuantidade)
        {
            _nome = pNome;
            _preco = pPreco;
            _quantidade = pQuantidade;
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

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }

        public override string ToString()
        {
            return $"{_nome}, R${_preco.ToString("F2", CultureInfo.InvariantCulture)}, {_quantidade} unidades," +
                    $" Total: ${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int pQuantidade)
        {
            _quantidade = _quantidade + pQuantidade;
        }

        public void RemoverProdutos(int pQuantidade)
        {
            _quantidade -= pQuantidade;
        }
    }
}
