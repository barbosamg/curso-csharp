using System;
using System.IO;
using System.Collections.Generic;

namespace Aula187Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\wamp64\www\UDEMY\c#\secao13\myFolder";

            try
            {
                //LISTAR PASTAS
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach(string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                //LISTAR ARQUIVOS
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                //CRIAR UMA PASTA
                Directory.CreateDirectory(path + @"\newFolder");

                //PODE-SE UTILIZA O DirectoryInfo
                DirectoryInfo di = new DirectoryInfo(path);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An erro ocurred {ex.Message}");
            }
        }
    }
}
