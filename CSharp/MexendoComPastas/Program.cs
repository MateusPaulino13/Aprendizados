using System;

namespace MexendoComPastas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\mateus.paulino\OneDrive - Adventistas\Documentos\myFolder";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");

                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine("|---------------------|");

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");

                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }

                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch(IOException e){
                Console.WriteLine("Error found");
                Console.WriteLine(e.Message);
            }
        }
    }
}