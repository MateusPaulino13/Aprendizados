using System;
using System.Globalization;
using OrderProduct.Entites;
using OrderProduct.Entites.Enums;

namespace OrderProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (dd/mm/yyyy): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many itens to this order? ");
            int qtdItens = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdItens; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");

                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int productQtd = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem item = new OrderItem(productQtd, productPrice, product);

                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("Order Summary: ");
            Console.WriteLine(order);
        }
    }
}