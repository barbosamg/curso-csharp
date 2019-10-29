using System;
using System.IO;

namespace Aula183File
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\wamp64\www\UDEMY\c#\secao13\file1.txt";
            string targetPath = @"C:\wamp64\www\UDEMY\c#\secao13\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line  in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error ocurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
