using Linq.Entities;
using System.Globalization;
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

            Category c1 = new Category(1, "Tools", 3);
            Category c2 = new Category(2, "Computers", 2);
            Category c3 = new Category(3, "Eletronics", 1);

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

            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            var r1 = from p in products
                     where p.Category.Tier == 1 && p.Price < 900.0
                     select p;
            Print("Tier 1 and Price < R$900.00 : ", r1);

            //var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var r2 = from p in products
                     where p.Category.Name == "Tools"
                     select p;
            Print("Names of Products frm Tools : ", r2);

            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var r3 = from p in products
                     where p.Name[0] == 'C'
                     select new
                     {
                         p.Name,
                         p.Price,
                         CategoryName = p.Category.Name
                     };
            Print("Names started  with 'C' and  Anonymous Object : ", r3);

            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 = from p in products
                     where p.Category.Tier == 1
                     orderby (p.Name)
                     orderby (p.Price)
                     select p;
            Print("Tier 1 Order By Price Then By Name : ", r4);

            //var r5 = r4.Skip(1).Take(2);
            var r5 = (from p in r4
                      select p)
                     .Skip(1)
                     .Take(2);

            Print("Skip 1 element and take 2 : ", r5);

            //var r6 = products.FirstOrDefault();
            var r6 = (from p in products select p)
                        .FirstOrDefault();
            Console.WriteLine("First or Dafault Test1: " + r6);

            //var r7 = products.Where(p => p.Price > 4000).FirstOrDefault();
            var r7 = (from p in products where p.Price > 4000 select p) .FirstOrDefault();
            Console.WriteLine("First or Dafault Test2: " + r7);
            Console.WriteLine();

            //só da pra usar o Single() ou SingleOrDefault() se você tiver certeza que irá retornar apenas um elemento de sua coleção
            //var r8 = products.Where(p => p.Name == "Hammer").SingleOrDefault();
            var r8 = (from p in products where p.Name == "Hammer" select p).SingleOrDefault();
            Console.WriteLine("Single or Default test 1 : " + r8);

            //var r9 = products.Where(p => p.Name == "Stratocaster").SingleOrDefault();
            var r9 = (from p in products where p.Name == "Stratocaster" select p).SingleOrDefault();
            Console.WriteLine("Single or Default test 2 : " + r9);

            Console.WriteLine();

            //var r10 = products.Max(p => p.Price);
            var r10 = (from p in products select p).Max(p => p.Price);
            Console.WriteLine($"Max Price : R${r10}");

            //var r11 = products.Min(p => p.Price);
            var r11 = (from p in products select p).Min(p => p.Price);
            Console.WriteLine($"Min Price : R${r11}");

            //var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            var r12 = (from p in products select p).Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine($"Category 1 sum prices : R${r12}");

            //var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            var r13 = (from p in products select p).Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine($"Category 1 avarage prices : R${r13.ToString("F2", CultureInfo.InvariantCulture)}");

            //para fugir da exeção de quando não tem valores, ele adiciona o DefaultIfEmpty para adicionar um valor padrão nestes casos e 'escapa' da exceção
            //var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            var r14 = (from p in products select p).Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine($"Category 5 avarage prices : R${r14.ToString("F2", CultureInfo.InvariantCulture)}");

            // para o mesmo esquema de cima (se não houver ou se a coleção for vazia) colocamos o valor padrão para o Aggregate, no seu primeiro parametro
            //var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x,  y) => x + y);
            var r15 = (from p in products select p).Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x,  y) => x + y);
            Console.WriteLine($"Category 1 Aggregate sum : R${r15}");

            Console.WriteLine();

            //var r16 = products.GroupBy(p => p.Category);
            var r16 = from p in products 
                      group p by p.Category;

            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine($"Category {group.Key.Name} : ");
                foreach(Product p in group)
                    Console.WriteLine(p);
                Console.WriteLine();
            }
        }
    }
}