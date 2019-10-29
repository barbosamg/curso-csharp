using System;

namespace Aula140TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine($"{n1}/{n2} = {result}");
            }
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Erro!! {e.Message}");
            //}
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Não é permitido dividir por zero!");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format error! {e.Message}");
            }
        }
    }
}
