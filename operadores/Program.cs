using System;

namespace operadores // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 2;

            //Console.WriteLine(a);

            //// += também serve para concatenar strings;
            //--a;

            //Console.WriteLine(a);


            //++a serve para adicionar antes da atribuição da variável

            int a = 10;
            int b = a++;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}