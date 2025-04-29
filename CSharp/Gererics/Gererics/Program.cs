namespace Gererics
{
    class Program
    {
        static void Main(string[] args)
        {
            // com uma classe, metodo ou interface usando o GENERICS
            // precisa que ela mostre o qual tipo ela vai receber, como abaixo:
            PrintService<int> ps = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                ps.AddValue(x);
            }
            
            // como o generics eu tenho segurando com Type safeting, então me dará erro em tempo de compilação
            // string a = (string)ps.First();
            
            ps.Print();
            Console.WriteLine($"First : {ps.First()}");
        }
    }
}