using HashSetSortedSet.Entites;
using System.Diagnostics.Metrics;

namespace HashSetSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conjuntos não aceitam repetições

            //var conjunto = new HashSet<string>();

            //conjunto.Add("Les Paul");
            //conjunto.Add("Vox ac30");
            //conjunto.Add("Valeton gp-200");

            //foreach (var conj in conjunto)
            //{
            //    Console.WriteLine(conj);
            //}

            //SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            //SortedSet<int> b = new SortedSet<int>() { 5, 6, 8, 11, 12, 15 };


            //union - só ira acrescentar os elementos não existiam ainda
            //estanciando um novo sortedSet baseado no 'a' (inserindo no 'c' todos os elementos do 'a')
            //SortedSet<int> c = new SortedSet<int>(a);
            //c.UnionWith(b);
            //PrintCollection(c);

            //intersection - aqueles elementos que existem nos dois conjuntos
            //SortedSet<int> inter = new SortedSet<int>(a);
            //inter.IntersectWith(b);
            //PrintCollection(inter);

            //difference - aqueles elementos que são diferentes nos conjuntos
            //SortedSet<int> diff = new SortedSet<int>(a);
            //diff.ExceptWith(b);
            //PrintCollection(diff);

            HashSet<Product> a = new HashSet<Product>()
            {
                new Product("Les Paul", 1000.00),
                new Product("Vox ac30", 1500.00),
                new Product("Valeton gp-200", 500.00)
            };

            HashSet<Point> b = new HashSet<Point>()
            {
                new Point(0, 0),
                new Point(1, 1),
                new Point(2, 2)
            };

            Product p = new Product("Les Paul", 1000.00);
            Point point = new Point(0, 0);

            // se a classe não tiver o método GetHashCode e Equals implementados, o HashSet não conseguirá identificar se o elemento já existe ou não
            // então ele irá considerar que o elemento é diferente, mesmo que os valores sejam iguais
            // vendo ele apenas por referencia e não por valor
            Console.WriteLine(a.Contains(p));
            Console.WriteLine(b.Contains(point));
        }

        static void PrintCollection<T>(IEnumerable<T> collections)
        {
            foreach (T obj in collections)
            {
                Console.Write($"{obj} ");
            }
            Console.WriteLine();
        }
    }
}
