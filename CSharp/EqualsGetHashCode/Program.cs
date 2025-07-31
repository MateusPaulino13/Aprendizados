using EqualsGetHashCode.Entities;

namespace EqualsGetHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "ronaldo";
            string b = "cleber";

            Console.WriteLine(a.Equals(b));

            //--GethashCode
            // metodo que retorna um numero inteiro representando um codigo gerado a partir das informações do objeto
            string c = "Maria";
            string d = "Alex";

            Console.WriteLine($"Maria : {c.GetHashCode()}");
            Console.WriteLine($"Alex : {d.GetHashCode()}");

            //comparações de objetos persolanizados
            Client c1 = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client c2 = new Client { Name = "Jonas", Email = "jonasdabiblia@gmail.com" };

            Console.WriteLine(c1.Equals(c2));
            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(c2.GetHashCode());
        }
    }
}
