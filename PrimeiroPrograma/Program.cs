using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace PrimeiroPrograma
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // para variaveis do tipo float, temos que colocar um f no final do número
            // para indicar que é float, diferente do double que não é necessário

            //float ProcentagemAcerto = 46.9f;

            //double VotosPrefeito = 50.9;

            //// representa um (1) caracter 
            //char letra = '\u0001';

            //string Name = "Mateus Paulino";

            //// tipo de variavel generica
            //object obj1 = "Jeferson";
            //object obj2 = 9.8f;

            //Console.WriteLine(ProcentagemAcerto);
            //Console.WriteLine(VotosPrefeito);
            //Console.WriteLine(letra);
            //Console.WriteLine(Name);
            //Console.WriteLine(obj1);
            //Console.WriteLine(obj2);

            double saldo = 19.874945;
            string name = "Mateus";
            int age = 16;

            //imprimir com 3 casas decimais
            Console.WriteLine(saldo.ToString("F3"));

            //imprimir com 3 casas decimais e com ponto no lugar da virgula
            //PRECISA do namespace System.Globalization
            Console.WriteLine(saldo.ToString("F3", CultureInfo.InvariantCulture));

            //-- Placeholders --//
            Console.WriteLine("{0} tem {1} anos e tem R${2:F2} de saldo na sua conta bancária", name, age, saldo);

            //-- Interpolação --//
            Console.WriteLine($"{name} tem {age} anos e tem R${saldo:F2} de saldo em sua conta bancária");

            //-- Concatenação --//
            Console.WriteLine(name + " tem " + age + " anos e tem R$" + saldo.ToString("F2") + " de saldo em sua conta bancária");
        }

    }
}