using System;
using System.Globalization;
using System.Security.Cryptography;

namespace Entrada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //split serve para divivir as strings pelo paramentro passa, no caso por um espaço em branco

            //string[] data = Console.ReadLine().Split(' ');

            //string name = data[0];
            //string last_name = data[1];
            //string age = data[2];

            //Console.WriteLine($"Seu nome é:  {name}");
            //Console.WriteLine($"Seu sobrenome é: {last_name}");
            //Console.WriteLine($"Sua idade é: {age} anos");


            //tem q fazer conversão para os tipos
            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());

            // CultureInfo.InvariantCulture para colocar/escrever  com ponto(.) no lugar da vírgula(,)
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] data = Console.ReadLine().Split(' ');

            string name = data[0];
            char sexo = char.Parse(data[1]);
            int age = int.Parse(data[2]);
            double height = double.Parse(data[3], CultureInfo.InvariantCulture);

            Console.Clear();

            //Console.WriteLine(n1);
            //Console.WriteLine(ch);
            //Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine($"Seu nome é: {name}");
            Console.WriteLine($"Seu sexo é: {sexo}");
            Console.WriteLine($"Sua idade é: {age} anos");
            Console.WriteLine($"Sua altura é: {height.ToString("F2", CultureInfo.InvariantCulture)} metros");
        }
    }
}