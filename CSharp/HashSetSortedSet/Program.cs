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

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 8, 11, 12, 15 };


            //union - só ira acrescentar os elementos não existiam ainda
            //estanciando um novo sortedSet baseado no 'a' (inserindo no 'c' todos os elementos do 'a')
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            //intersection - aqueles elementos que existem nos dois conjuntos
            SortedSet<int> inter = new SortedSet<int>(a);
            inter.IntersectWith(b);
            PrintCollection(inter);

            //difference - aqueles elementos que são diferentes nos conjuntos
            SortedSet<int> diff = new SortedSet<int>(a);
            diff.ExceptWith(b);
            PrintCollection(diff);
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
