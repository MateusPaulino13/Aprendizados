using System;

namespace FuncString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "       abcd ABCD AbCd           ";

            //transforma para minuscula
            Console.WriteLine($"Minuscula: -{text.ToLower()}-");

            //transforma para maiuscula
            Console.WriteLine($"Maiuscula: -{text.ToUpper()}-");

            //Tira os espacos em branco tanto antes tanto depois da string
            Console.WriteLine($"Maiuscula: -{text.Trim()}-");

            Console.WriteLine($"{text.IndexOf("ab")}");
            Console.WriteLine($"{text.LastIndexOf("d")}");

            //para pegar parte de uma string apartir ou de um numero de inicio ou um numero de inicio e quantidade apartir daquele numero
            Console.WriteLine($"Nova string:-{text.Substring(7, 4)}-");

            //ela substitui uma parte da string apartir de um caracter ou uma string
            Console.WriteLine($"Replace: -{text.Replace("abcd", "fabio")}-");

            //verifica se a string é vazia ou nula
            bool emptyOrNull = String.IsNullOrEmpty(text);
            Console.WriteLine((emptyOrNull) ? "É vazia ou nula" : "não é vazia ou nula");

            //verifica se a string é nula ou é apenas um monte de espaço em branco
            bool nullOrWhiteSpace = String.IsNullOrWhiteSpace(text);
            Console.WriteLine((emptyOrNull) ? "É nula ou espaço em branco" : "não é nula ou espaço em branco");
        }
    }
}