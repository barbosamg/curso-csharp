using System;

namespace Aula81ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            int[,] matriz = new int[numberOne, numberTwo];

            for (int i = 0; i < numberOne; i++)
            {
                string[] valores = Console.ReadLine().Split('-');
                for (int j = 0; j < numberTwo; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            int numberX = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOne; i++)
            {
                for (int j = 0; j < numberTwo; j++)
                {
                    if (matriz[i, j] == numberX)
                    {
                        Console.WriteLine($"Position: {i},{j}");
                        if (j > 0)
                        {
                            Console.WriteLine($"Left: {matriz[i, j - 1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Up: {matriz[i - 1, j]}");
                        }
                        if (j < numberTwo - 1)
                        {
                            Console.WriteLine($"Right: {matriz[i, j + 1]}");
                        }
                        if (i < numberOne - 1)
                        {
                            Console.WriteLine($"Down: {matriz[i + 1, j]}");
                        }
                    }
                }
            }

        }
    }
}
