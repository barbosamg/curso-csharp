using System;

namespace Aula73ModificadorParametro
{
    class Program
    {
        static void Main(string[] args)
        {
            //MODIFICADOR REF
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            //modificador out
            int b = 15;
            int triple;
            Calculator.TripleOut(b, out triple);
            Console.WriteLine(triple);
        }
    }
}
