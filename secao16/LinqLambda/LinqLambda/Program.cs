using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 3, 4, 5 };

            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
