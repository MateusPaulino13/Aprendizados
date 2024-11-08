using System;

namespace RepeticaoFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //entrada de dados
            Console.Write("Quantos números inteiros você irá digitar? ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;

            //entrada de dados e tratamento
            for (int a = 1; a <= n; a ++)
            {
                Console.WriteLine($"Digite o valor #{a} ");
                int n2 = int.Parse(Console.ReadLine());

                soma += n2;
            }

            //saída de dados
            Console.WriteLine($"A soma total foi de: {soma}");
        }
    }
}