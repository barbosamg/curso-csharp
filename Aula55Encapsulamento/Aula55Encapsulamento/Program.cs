using System;
using System.Globalization;

namespace ConstrutorAula51
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p= new Produto();
            p.SetNome("Notebook");
            Console.WriteLine(p.GetNome());

            Console.ReadKey();
        }
    }
}
