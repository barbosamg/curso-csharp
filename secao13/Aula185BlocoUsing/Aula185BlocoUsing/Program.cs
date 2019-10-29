using System;
using System.IO;

namespace Aula185BlocoUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\wamp64\www\UDEMY\c#\secao13\185.txt";

            //try
            //{
            //    using (FileStream fs = new FileStream(path, FileMode.Open))
            //    {
            //        using (StreamReader sr = new StreamReader(fs))
            //        {
            //            while (!sr.EndOfStream)
            //            {
            //                string line = sr.ReadLine();
            //                Console.WriteLine(line);
            //            }
            //        }
            //    }
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine($"An error ocurred: {ex.Message}");
            //}

            //OU DESSA FORMA:
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An error ocurred: {ex.Message}");
            }
        }
    }
}
