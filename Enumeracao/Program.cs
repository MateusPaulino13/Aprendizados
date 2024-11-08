using Enumeracao.Entities;
using Enumeracao.Entities.Enums;
using System;

namespace Enumeracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order ap = new Order { Id = 490, Moment = DateTime.Now, Status = OrderStatus.PendingPayment };
            Console.WriteLine(ap);

            string tt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(tt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}