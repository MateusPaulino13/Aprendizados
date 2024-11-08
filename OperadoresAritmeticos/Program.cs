using System;

namespace OperadoresAritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double s = 2.0 / 4;

            //Console.WriteLine(s);


            //formula de baskara

            double a = 1.0, b = -3.0, c = -4.0;

            // Math.Pow() == potência
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            // Math.Sqrt() == raíz quadrada 
            double x = (-b * Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x);
        }
    }
}

