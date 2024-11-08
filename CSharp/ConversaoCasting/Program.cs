using System;

namespace ConversaoCasting // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conversão implicita
            //float cabe dentro de double mas não ao contrário

            //4 bytes
            //float x = 10.45f;

            ////8 bytes
            //double y = x;

            //Console.WriteLine(y);


            //casting = falar para o compilador que está td bem se colocar um
            //conteudo de 8 bytes em um de 4 bytes

            //double a = 5.6;
            //int b = (int)a;
            //float b = (float)a;


            //Console.WriteLine(b);


            int a = 5;
            int b = 8;

            double result = (double)a / b;

            Console.WriteLine(result);
        }
    }
}