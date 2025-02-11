using ProductUsedImported.Entites;
using System;
using System.Collections.Generic;

namespace ProductUsedImported
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (type == 'i' || type == 'I')
                {
                    Console.Write("Custom fee: ");
                    double customsFee = double.Parse(Console.ReadLine());

                    products.Add(new ImportedProduct(name, price, customsFee));
                } else if(type == 'u' || type == 'U')
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, manufactureDate));
                } else if(type == 'c' || type == 'C')
                {
                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Price Tags: ");
            foreach (Product product in products)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}