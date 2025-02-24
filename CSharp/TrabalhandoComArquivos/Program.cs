using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\mateus.paulino\OneDrive - Adventistas\Documentos\Aprendizados\text.txt";

            try
            {
                // tudo dentro desse bloco using sera feito e ao terminar a execução de todas as ações, ele irá fechar o arquivo
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string lines = sr.ReadLine();
                        Console.WriteLine(lines);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}