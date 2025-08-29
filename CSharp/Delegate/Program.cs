using Delegate.Entities;
using Delegate.Services;

namespace Delegate
{
    delegate void BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 3;

            //passando a referencia do metodo do service
            // só pode usar as funções/métodos que casam com a assinatura, não posso (neste caso) colocar uma função que recebe apenas um paramentro ou que tenha outro tipo de retorno
            // como no caso da função Square do CalculationService
            //BinaryNumericOperation op = CalculationService.Sum;
            //BinaryNumericOperation opVerboso = new BinaryNumericOperation(CalculationService.Sum); // muito verboso;

            //double resultInvoke = op.Invoke(a, b); //Ele esta chamando/"Invocando" a função/método que você definiu (no nosso caso é Sum())
            //double result = op(a, b);
            //Console.WriteLine(result);


            //Multicast Delegates são delegates que guardam referencia para mais de um método
            // para adicionar uma referencia, pode-se usar o operador +=
            //A chamada Invoke(ou sintaxe resuzida) executa todos os métodos na ordem em que foram adicionados
            // Seu uso faz sentido para métodos VOID
            //BinaryNumericOperation op = CalculationService.ShowSum;
            //op += CalculationService.ShowMax;

            //op.Invoke(a, b);
            //op(a, b);


            //PREDICATE = Representa um método que recebe um objeto do tipo T e retorna um valor booleano
            //List<Product> products = new List<Product>();

            //products.Add(new Product("Stratocaster", 1740.00));
            //products.Add(new Product("Vox ac30", 4500.00));
            //products.Add(new Product("Valeton Gp-200", 1500.00));

            //products.RemoveAll(p => p.Price > 1500.00); // pode ser uma expressão lambda
            //products.RemoveAll(ProductTest); 

            //foreach(var prod in products)
            //    Console.WriteLine(prod);



            //ACTION = Representa um método void que recebe zero ou mais argumentos
            //List<Product> products = new List<Product>();

            //products.Add(new Product("Stratocaster", 1740.00));
            //products.Add(new Product("Vox ac30", 4500.00));
            //products.Add(new Product("Valeton Gp-200", 1500.00));

            //Action<Product> act = UpdatePrice;
            //Action<Product> act = p => { p.Price += p.Price * 0.1; };

            //products.ForEach(UpdatePrice);
            //products.ForEach(p => { p.Price += p.Price * 0.1; });
            //products.ForEach(act);

            //foreach(Product p in products)
            //    Console.WriteLine(p);


            //FUNC = Representa um método que recebe zero ou mais argumentos, e retorna um valor
            // a diferença entre o Action e o Func, é que o Func retorna algum valor
            List<Product> products = new List<Product>();

            products.Add(new Product("Stratocaster", 1740.00));
            products.Add(new Product("Vox ac30", 4500.00));
            products.Add(new Product("Valeton Gp-200", 1500.00));

            //Func<Product, string> func = NameUpper;

            //List<string> result = products.Select(func).ToList();
            List<string> result = products.Select(p => p.Name.ToUpper()).ToList();

            foreach (var p in result)
                Console.WriteLine(p);
        }

        //static string NameUpper(Product p)
        //{
        //    return p.Name.ToUpper();
        //}

        //static void UpdatePrice(Product prod)
        //{
        //    prod.Price += prod.Price * 0.1;
        //}

        //public static bool ProductTest(Product p)
        //{
        //    return p.Price > 1500.00;
        //}
    }
}
