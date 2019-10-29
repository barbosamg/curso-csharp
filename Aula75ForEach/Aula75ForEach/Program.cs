using System;

namespace Aula75ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Mateus", "Junia", "Maria" };

            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("--------------------------------------------");

            foreach(string elem in vect)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
