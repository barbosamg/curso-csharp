using System;

namespace Aula79Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[2, 5];

            Console.WriteLine(matriz.Length);
            Console.WriteLine(matriz.Rank);
            Console.WriteLine(matriz.GetLength(0));
            Console.WriteLine(matriz.GetLength(1));
        }
    }
}
