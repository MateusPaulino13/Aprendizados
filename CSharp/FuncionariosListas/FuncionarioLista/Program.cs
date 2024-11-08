using System;
using System.Collections.Generic;

namespace FuncionarioLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionarios você gostaria de registrar? ");
            int qtdFunc = int.Parse(Console.ReadLine());

            List<Funcionario> func = new();

            for (int i = 0; i < qtdFunc; i++)
            {
                Console.WriteLine($"Funcionário #{i + 1}:");

                Console.Write("Qual o Id do funcionário? ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Qual o Nome do funcionário? ");
                string nome = Console.ReadLine();

                Console.Write("Qual o Salario do funcionário? ");
                double salario = double.Parse(Console.ReadLine());

                Funcionario funcionario = new Funcionario(id, nome, salario);
                func.Add(funcionario);

                Console.WriteLine("\n");
            }

            // Exibindo informações de todos os funcionários
            foreach (Funcionario i in func)
            {
                Console.WriteLine($"Id: {i.Id}");
                Console.WriteLine($"Nome: {i.Name}");
                Console.WriteLine($"Salário: {i.Salario}");
                Console.WriteLine();
            }


            Console.Write("Digite o Id que você gostaria de aumentar o salario: ");
            int idSelected = int.Parse(Console.ReadLine());

            // Encontrar o funcionário pelo Id
            Funcionario idAumento = func.Find(x => x.Id == idSelected);

            if (idAumento != null)
            {
                Console.WriteLine($"Funcionário encontrado: {idAumento.Name}");
                // Aqui você pode adicionar a lógica para aumentar o salário
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }
    }
}
