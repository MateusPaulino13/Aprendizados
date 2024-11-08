using System;
using System.Xml;

namespace EstruturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite um número: ");
            //int num1 = int.Parse(Console.ReadLine());

            //if (num1 % 2 == 0)
            //{
            //    Console.WriteLine("O número escolhido é: Par");
            //} else
            //{
            //    Console.WriteLine("O número escolhido é: Impar");
            //}

            Console.WriteLine("Digite às Horas: ");

            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia");
            } else if(hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde");
            } else
            {
                Console.WriteLine("Boa noite");
            }
        }
    }
}