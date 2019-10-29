using System;

namespace Aula66
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Point p;
            p.X = 50;
            p.Y = 15;
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);*/

            

            //ATRIBUINDO VALOR NULL A UMA VARIAVEL NAO NULL
            //Nullable<double> a = null; OU
            double? a = null;
            double? b = 10.0;

            Console.WriteLine(a.GetValueOrDefault());
            Console.WriteLine(b.GetValueOrDefault());

            Console.WriteLine(a.HasValue);
            Console.WriteLine(b.HasValue);

            if(a.HasValue)
                Console.WriteLine(a.Value);
            else
                Console.WriteLine("X É NULL");

            if(b.HasValue)
                Console.WriteLine(b.Value);
            else
                Console.WriteLine("B É NULO");

            double? c = null;
            double? d = 10.0;

            double e = c ?? 5;
            double f = d ?? 5;

            Console.WriteLine(e);
            Console.WriteLine(f);

            Console.ReadLine();
        }
    }
}
