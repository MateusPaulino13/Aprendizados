using System;
using System.Collections.Generic;

namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double[,] matriz = new double[2, 3];

            //retorna quantos elementos tem na matriz
            //Console.WriteLine(matriz.Length);

            //retorna a primeira dimenção da matriz (ou quantidade de linhas)
            //Console.WriteLine(matriz.Rank);

            //Console.WriteLine(matriz.GetLength(0));
            //Console.WriteLine(matriz.GetLength(1));

            Console.Write("Digite o tamanho da matriz que você deseja digitar: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(" ");
                for (int j = 0;j < n; j++)
                {
                    mat[i,j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine();
            Console.Write("Diagonal principal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{ mat[i, i]} ");
            }

            int contagem = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        contagem++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Números negativos: {contagem}");
        }
    }
}