using ProblemWithPoo;
using System;
using System.Globalization;

namespace ProblemWittPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variaveis 
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X");

            //entrada de dados
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // processamento de dados
            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();

            //saída de dados
            Console.WriteLine($"Área do triângulo X = {areaX.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área do triângulo Y = {areaY.ToString("F3", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
            {
                Console.WriteLine("Área do triângulo X é a maior");
            }
            else
            {
                Console.WriteLine("Área do triângulo Y é a maior");
            }
        }
    }
}
