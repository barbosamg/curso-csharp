using Aula189Exercicio.Entities;
using System;
using System.Globalization;
using System.IO;

namespace Aula189Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcetPath = @"C:\wamp64\www\UDEMY\c#\secao13\arquivos_exercicio\vendas.csv";

            try
            {
                string[] lines = File.ReadAllLines(sourcetPath);
                string sourceFolderPath = Path.GetDirectoryName(sourcetPath);
                string targetFolderPath = sourceFolderPath + Path.DirectorySeparatorChar + @"out";
                string targetFilePath = targetFolderPath + Path.DirectorySeparatorChar + @"summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrEmpty(line.Trim()))
                        {
                            string[] fields = line.Split(';');
                            string name = fields[0];
                            decimal price = decimal.Parse(fields[1]);
                            int quantity = int.Parse(fields[2]);

                            Product product = new Product(name, price, quantity);

                            sw.WriteLine($"{product.Name}; {product.Total().ToString("F2", CultureInfo.InvariantCulture)}");
                        }
                    }
                }

                Console.WriteLine("SUCESSO!!!");
                Console.ReadKey();
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
