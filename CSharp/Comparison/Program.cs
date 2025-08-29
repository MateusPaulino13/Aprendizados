using Comparison.Entites;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {

            var produtcs = new List<Product>();

            produtcs.Add(new Product("Seizi Stratocaster", 3500.00));
            produtcs.Add(new Product("Gibson SG", 9800.00));
            produtcs.Add(new Product("Tagima Grace 7.7", 12900.90));

            // ordena minha lista
            // mas apenas se minha lista implementa a interface IComparable<>
            produtcs.Sort();

            foreach (var product in produtcs)
            {
                Console.WriteLine(product);
            }

        }
    }
}
