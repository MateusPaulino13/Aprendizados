using Gererics.Entities;
using Gererics.Services;
using System.Globalization;

namespace Gererics
{
    class Program
    {
        static void Main(string[] args)
        {
            // com uma classe, metodo ou interface usando o GENERICS
            // precisa que ela mostre o qual tipo ela vai receber, como abaixo:

            //PrintService<int> ps = new PrintService<int>();

            //Console.Write("How many values? ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    ps.AddValue(x);
            //}

            // como o generics eu tenho segurando com Type safeting, então me dará erro em tempo de compilação
            // string a = (string)ps.First();

            //ps.Print();
            //Console.WriteLine($"First : {ps.First()}");


            List<Product> list = new List<Product>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(',');
                string name = vet[0];
                double price = double.Parse(vet[1], CultureInfo.InvariantCulture);

                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();
            Product max = calculationService.Max(list);

            Console.Write($"Max : {max}");
        }
    }
}