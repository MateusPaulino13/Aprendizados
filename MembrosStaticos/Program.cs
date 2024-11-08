using System;
using System.Globalization;

namespace MembrosStaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );

            double circ = Calculadora.Circuferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circuferência é igual a: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume é igual a: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Pi é igual a: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}