using System;
using Aula115Enumeracao.Entities;
using Aula115Enumeracao.Entities.Enums;

namespace Aula115Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1082,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            System.Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            System.Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            System.Console.WriteLine(os);
        }
    }
}
