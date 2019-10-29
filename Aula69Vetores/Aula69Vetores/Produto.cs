using System;
using System.Globalization;

namespace Aula69Vetores
{
    class Produto
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Nome: {Name} | Preço: {Price}";
        }
    }
}
