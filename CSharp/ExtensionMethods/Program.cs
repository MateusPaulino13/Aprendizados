using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2025, 8, 28, 16, 40, 10);
            Console.WriteLine(dt.ElapsedTime());

            string phase = "My name is Mateus Paulino and i like guitar";
            Console.WriteLine(phase.Cut(14));
        }
    }
}
