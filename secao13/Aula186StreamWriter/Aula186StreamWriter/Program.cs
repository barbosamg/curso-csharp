using System;
using System.IO;

namespace Aula186StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\wamp64\www\UDEMY\c#\secao13\186.txt";
            string targetPath = @"C:\wamp64\www\UDEMY\c#\secao13\186-2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An erro ocurred {ex.Message}");
            }
        }
    }
}
