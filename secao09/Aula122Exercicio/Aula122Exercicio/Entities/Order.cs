using System;
using System.Collections.Generic;
using System.Text;
using Aula122Exercicio.Entities.Enums;

namespace Aula122Exercicio.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus orderStatus, Client client)
        {
            Moment = moment;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine($"Order moment: {Moment}");
            sb.AppendLine($"Order status: {OrderStatus}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate}) - {Client.Email}");
            sb.AppendLine();
            sb.AppendLine("Order Items:");
            foreach(OrderItem orderItem in Items)
            {
                sb.AppendLine($"{orderItem.Product.Name}, {orderItem.Price}, Quantity: {orderItem.Quantity}, Subtotal: {orderItem.SubTotal()} ");
            }
            sb.AppendLine($"Total price: {Total()}");
            return sb.ToString();            
        }
    }
}
