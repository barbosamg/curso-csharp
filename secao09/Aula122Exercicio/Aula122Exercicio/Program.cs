using System;
using Aula122Exercicio.Entities;
using Aula122Exercicio.Entities.Enums;

namespace Aula122Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string nameClient = Console.ReadLine();
            Console.Write("Email: ");
            string emailClient = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(nameClient,emailClient,birthDate);

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Enter order data:");
            Console.Write("Status (PendingPayment/Processing/Shipped/Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now,status,client);
            Console.Write("How many items to this order? ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantityProduct = int.Parse(Console.ReadLine());

                Product product = new Product(nameProduct,priceProduct);
                OrderItem orderItem = new OrderItem(quantityProduct,priceProduct,product);
                order.AddItem(orderItem);
            }

            Console.WriteLine(order);
        }
    }
}
