using System;

namespace OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b1 = 1 < 4 || 4 > 7;

            if (!b1 == true)
            {
                Console.WriteLine("Normal");
            } else
            {
                Console.WriteLine("Oxi");
            }
        }
    }
}