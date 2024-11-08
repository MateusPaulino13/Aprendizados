using System;
using System.Globalization;

namespace RepeticaoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //entrada de dados
            Console.WriteLine("Digite um número: ");
            double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //estrutura de repetição com entrada de dados e tratamento
            while (number >= 0.0)
            {
                double Raiz = Math.Sqrt(number);

                Console.WriteLine($"Resultado foi: {Raiz.ToString("F3", CultureInfo.InvariantCulture)}");


                Console.WriteLine("Digite outro número: ");
                number = double.Parse(Console.ReadLine());
            }

            //resultado se negativo
            Console.WriteLine("Número negativo");
        }
    }
}