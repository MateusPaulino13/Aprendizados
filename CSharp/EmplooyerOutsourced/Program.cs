using EmplooyerOutsourced.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace EmplooyerOutsourced
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de funcionários que deseja cadastrar: ");
            int qntFunc = int.Parse(Console.ReadLine());

            List<Emplooyee> emplooyees = new List<Emplooyee>();

            for (int i = 1; i <= qntFunc; i++)
            {
                Console.Write($"Digite os dados do funcionário #{i}: ");

                Console.Write("Terceirizado (s/n)? ");
                char terceirizado = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (terceirizado == 's' || terceirizado == 'S')
                {
                    Console.Write("Custo adicional: ");
                    double custoAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    emplooyees.Add(new OutsourcedEmplooyee(nome, horas, valorPorHora, custoAdicional));
                }
                else
                {
                    emplooyees.Add(new Emplooyee(nome, horas, valorPorHora));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pagamentos");

            foreach (Emplooyee func in emplooyees)
            {
                Console.WriteLine($"{func.Name} - R${func.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}