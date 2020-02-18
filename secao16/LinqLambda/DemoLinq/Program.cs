using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLinq.Entities;

namespace DemoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 1 };
            Category c2 = new Category() { Id = 2, Name = "Games", Tier = 2 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 3 };

            List<Product> products = new List<Product>()
            {
                new Product(){Id = 1, Name= "PS4", Price = 2100.00, Category = c2},
                new Product(){Id = 2, Name= "Hammer", Price = 70.00, Category = c1},
                new Product(){Id = 3, Name= "X-Box", Price = 1200.00, Category = c2},
                new Product(){Id = 4, Name= "Saw", Price = 25.00, Category = c1},
                new Product(){Id = 5, Name= "TV", Price = 700.00, Category = c3},
                new Product(){Id = 6, Name= "Level", Price = 55.00, Category = c1},
                new Product(){Id = 7, Name= "Notebook", Price = 1500.00, Category = c3},
                new Product(){Id = 8, Name= "Nintendo", Price = 850.00, Category = c2},
                new Product(){Id = 9, Name= "AOC", Price = 850.00, Category = c2},
            };

            IEnumerable<Product> result1 = products
                .Where(p => p.Category.Tier == 1 && p.Price < 65);
            result1.Print("Tier 1 and price < 60");

            IEnumerable<string> result2 = products
                .Where(p => p.Category.Name == "Tools")
                .Select(c => c.Name);
            result2.Print("Name of products from tools");

            var result3 = products.Where(p => p.Name[0] == 'N')
                .Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            result3.Print("Names started with 'N' and anonumous object");

            var result4 = products.Where(p => p.Category.Tier == 2)
                .OrderBy(p => p.Price)
                .ThenBy(p => p.Name)
                .Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            result4.Print("Tier 1 order by price then by name");

            var result5 = result4.Skip(1).Take(2);
            result5.Print("Result 4 Skip 1 take 2");

            Product result6 = products.First();
            Console.WriteLine("First product: " + result6);

            Product result7 = products.Where(p => p.Price > 3000.00).FirstOrDefault();
            Console.WriteLine($"FirstOrDefault: {result7}");

            Product result8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine($"Single or default conditional: {result8}");

            var result9 = products.Max(p => p.Price);
            Console.WriteLine($"Max Price: {result9}");

            var result10 = products.Min(p => p.Price);
            Console.WriteLine($"Min price: {result10}");

            double r11 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine($"Category 1 sum: {r11}");

            double r12 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine($"Category 1 Average: {r12}");

            double r13 = products.Where(p => p.Category.Id == 6)
                .Select(p => p.Price)
                .DefaultIfEmpty(0)
                .Average();
            Console.WriteLine($"Category 6 DefaultIfEmpty/Average: {r13}");

            var r14 = products
                .Where(p => p.Category.Id == 1)
                .Select(p => p.Price)
                .DefaultIfEmpty(0)
                .Aggregate((a, b) => a - b);
            Console.WriteLine($"Category 1 aggregate subtract: {r14}");

            var r15 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> item in r15)
            {
                Console.WriteLine($"Category: {item.Key.Name}");
                foreach (var product in item)
                {
                    Console.WriteLine($"Product: {product.Name}");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
