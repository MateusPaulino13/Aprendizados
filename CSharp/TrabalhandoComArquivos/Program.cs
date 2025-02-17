using System;

namespace TrabalhandoComArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\mateus.paulino\Downloads\msg.txt";
            string targetPath = @"C:\Users\mateus.paulino\Downloads\msg2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            } finally
            {

            }
        }
    }
}