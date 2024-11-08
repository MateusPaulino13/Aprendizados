using System;
using System.Globalization;
using System.Security.Cryptography;

namespace ProdutoEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto();

            Console.WriteLine("Entrada de dados do produto: ");

            Console.Write("Nome: ");
            prod.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            prod.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            prod.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"Dados do Produto: {prod}");

            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionados ao estoque: ");
            int qnt = int.Parse(Console.ReadLine());
            
            prod.AdicionarProduto(qnt);

            Console.WriteLine();

            Console.WriteLine($"Dados Atualizados: {prod}");

            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            qnt = int.Parse(Console.ReadLine());

            prod.RemoverProdutos(qnt);

            Console.WriteLine();

            Console.WriteLine($"Dados Atualizados: {prod}");
        }
    }
}