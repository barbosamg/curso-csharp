using System;
using System.Globalization;

namespace ConstrutorAula51
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.Nome = "Celular";
            Console.WriteLine(p.Nome);

            Console.ReadKey();
        }
    }
}
