using System;
using System.Collections.Generic;
using System.Text;

namespace Aula189Exercicio.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public decimal Total()
        {
            return Quantity * Price;
        }
    }
}
