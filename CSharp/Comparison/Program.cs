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
            //produtcs.Sort();

            //gardando a referencia da função
            //Comparison<Product> comp = Compareproduts;

            //função anonima para não precisar criar uma função dedicada para isso
            //Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            //produtcs.Sort(comp);

            //ou msm se preferir, pode colocar a propria expressão lambda direto no sort()
            produtcs.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (var product in produtcs)
                Console.WriteLine(product);

        }

        //static int Compareproduts(Product prod1, Product prod2)
        //{
        //    return prod1.Name.ToUpper().CompareTo(prod2.Name.ToUpper());
        //}
    }
}
