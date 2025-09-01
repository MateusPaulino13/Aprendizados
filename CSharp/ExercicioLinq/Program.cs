using ExercicioLinq.Entities;
using System.Globalization;
using System.Linq;

namespace ExercicioLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full file path : ");
            var filePath = Console.ReadLine();

            var products = new List<Product>();

            using (StreamReader sr = File.OpenText(filePath))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);

                    products.Add(new Product(name, price));
                }
            }

            var avg = products
                .Select(p => p.Price)
                .DefaultIfEmpty(0.0)
                .Average();

            var names = products
                .Where(p => p.Price < avg)
                .OrderByDescending(p => p.Name)
                .Select(p => p.Name);

            Console.WriteLine($"Average price = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
            foreach (var prod in names)
                Console.WriteLine(prod);
        }
    }
}
