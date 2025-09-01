using Linq.Entities;
using System.IO.Pipes;

namespace Linq
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collections)
        {
            Console.WriteLine(message);
            foreach (T obj in collections)
                Console.WriteLine(obj);

            Console.WriteLine();
        }

        private static void Main(string[] args)
        {
            //Três passos pra trabalhar com LINQ
            //1º - Criar um data source (coleção, array, recurso de Entrada/Saída, etc)
            //2º - Definir a Query
            //3º Executar a Query (foreach ou alguma operação terminal)
            // Data Source -> Query -> Execution

            //data source
            //int[] numbers = new int[] { 1, 2, 3 };

            //// query expression definition
            //var result = numbers
            //    .Where(x => x % 2 == 0)
            //    .Select(x => x * 10);

            ////execute the query
            //foreach (var x in result)
            //    Console.WriteLine(x);

            Category c1 = new Category(new Guid(), "Tools", 3);
            Category c2 = new Category(new Guid(), "Computers", 2);
            Category c3 = new Category(new Guid(), "Eletronics", 1);

            var products = new List<Product>()
            {
                new Product(Guid.NewGuid(), "Computer", 1100.00, c2),
                new Product(Guid.NewGuid(), "Computer", 1100.00, c2),
                new Product(Guid.NewGuid(), "Monitor", 600.00, c3),
                new Product(Guid.NewGuid(), "Keyboard", 100.00, c3),
                new Product(Guid.NewGuid(), "Hammer", 25.00, c1),
                new Product(Guid.NewGuid(), "Screwdriver", 15.00, c1),
                new Product(Guid.NewGuid(), "Headphones", 150.00, c3),
                new Product(Guid.NewGuid(), "Laptop", 2100.00, c2),
                new Product(Guid.NewGuid(), "Smartphone", 800.00, c3),
                new Product(Guid.NewGuid(), "Drill", 90.00, c1),
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("Tier 1 and Price < R$900.00 : ", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("Names of Products frm Tools : ", r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("Names started  with 'C' and  Anonymous Object : ", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Tier 1 Order By Price Then By Name : ", r4);

            var r5 = r4.Skip(1).Take(2);
            Print("Skip 1 element and take 2 : ", r5);

            var r6 = products.FirstOrDefault();
            Console.WriteLine("First or Dafault Test1: " + r6);

            var r7 = products.Where(p => p.Price > 4000).FirstOrDefault();
            Console.WriteLine("First or Dafault Test2: " + r7);
            Console.WriteLine();

            //só da pra usar o Single() ou SingleOrDefault() se você tiver certeza que irá retornar apenas um elemento de sua coleção
            var r8 = products.Where(p => p.Name == "Hammer").SingleOrDefault();
            Console.WriteLine("Single or Default test 1 : " + r8);

            var r9 = products.Where(p => p.Name == "Stratocaster").SingleOrDefault();
            Console.WriteLine("Single or Default test 2 : " + r9);
        }
    }
}