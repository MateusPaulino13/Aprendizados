using System;

namespace exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            Pessoa personX = new Pessoa();
            Pessoa personY = new Pessoa();

            //premeira pessoa
            Console.WriteLine("Coloque os dados da primeira pessoa: ");
            Console.Write("Nome: ");
            personX.Name = Console.ReadLine();
            
            Console.Write("Idade: ");
            personX.Age = int.Parse(Console.ReadLine());

            //segunda pessoa
            Console.WriteLine("Coloque os dados da segunda pessoa: ");
            Console.Write("Nome: ");
            personY.Name = Console.ReadLine();

            Console.Write("Idade: ");
            personY.Age = int.Parse(Console.ReadLine());

            if (personX.Age > personY.Age)
            {
                Console.WriteLine($"{personX.Name} é a pessoa mais velha");
            } else
            {
                Console.WriteLine($"{personY.Name} é a pessoa mais velha");
            }
        }
    }
}