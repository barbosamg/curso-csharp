using System;

namespace Aula72Params
{
    class Program
    {
        static void Main(string[] args)
        {
            //nao preciso instanciar um array como no s2, pois possui o params na assinatura do metodo
            int s1 = Calculator.Sum(2, 3, 5, 8);
            int s2 = Calculator.Sum(new int[] { 10, 15, 18, 2, 3 });

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
