using System;
using System.Collections.Generic;

namespace TarefaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o tamanho da matriz que você deseja calcular? ");
            string[] inputs = Console.ReadLine().Split(" ");
            int row = int.Parse(inputs[0]);
            int col = int.Parse(inputs[1]);

            int[,] mat = new int[row, col];

            for(int i = 0; i < row; i++)
            {
                string[] valores = Console.ReadLine().Split(" ");
                for (int j = 0; j < col; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.Write("Digite o número que deseja procurar: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (mat[i,j] == num)
                    {
                        Console.WriteLine($"Top: {mat[i - 1,j]}");
                        Console.WriteLine($"Bottom: {mat[i + 1, j]}");
                        Console.WriteLine($"Left: {mat[i, j - 1]}");
                        Console.WriteLine($"Right: {mat[i, j + 1]}");
                    }
                }
            }
        }
    }
}