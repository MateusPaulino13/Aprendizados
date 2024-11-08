using System;
using System.Globalization;

namespace ProblemWithoutPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variaveis 
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X");

            //entrada de dados
            xA= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y");

            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // processamento de dados
            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

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