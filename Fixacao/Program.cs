using System;
using System.Globalization;

namespace Fixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aluno aluno = new Aluno();

            //Console.Write("Escreva a nome do Aluno: ");
            //aluno.Name = Console.ReadLine();

            //Console.WriteLine("Digite as três notas do Auno: ");
            //aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //aluno.NotaFinal = aluno.Nota1 + aluno.Nota2 + aluno.Nota3;

            //Console.WriteLine($"Nota Final: {aluno.NotaFinal}");

            //aluno.isAprovado();

            //if (aluno.isAprovado() == true)
            //{
            //    Console.WriteLine("Aprovado");
            //} else
            //{
            //    Console.WriteLine("Reprovado");
            //    Console.WriteLine($"Pontos Faltantes: {aluno.Restante()}");
            //}



            Console.WriteLine($"Qual é a cotação do Dolar: {Conversor.Cotacao}");

            Console.Write("Quantos Dolares você irá comprar? ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pagar = Conversor.TotalaSerPago(dolares);
            Console.WriteLine($"Valor a ser pago: {pagar}");

        }
    }
}
