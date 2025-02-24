using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace TrabalhandoComArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"C:\Users\mateus.paulino\OneDrive - Adventistas\Documentos\Aprendizados\text.txt";
            string targetPath = @"C:\Users\mateus.paulino\OneDrive - Adventistas\Documentos\Aprendizados\text2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcepath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error found");
                Console.WriteLine(e.Message);
            }
        }
    }
}