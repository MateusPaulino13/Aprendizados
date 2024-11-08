using System;

namespace ExpressaoTernaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double note = double.Parse(Console.ReadLine());
            string noteResult = (note < 6) ? "Recuperação" : "Passou";
            Console.WriteLine(noteResult);
        }
    }
}