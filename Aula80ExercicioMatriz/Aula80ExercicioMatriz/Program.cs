using System;

namespace Aula80ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            int[,] matriz = new int[numero, numero];

            for (int i = 0; i < numero; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < numero; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine($"{matriz[i, i]} ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < numero; i++)
            {
                for (int j = 0; j < numero; j++)
                {
                    if(matriz[i,j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Negative numbers: {count}");
        }
    }
}
