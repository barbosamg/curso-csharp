using System;

namespace Aula93OperacoesTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            // TimeSpan t1 = TimeSpan.MaxValue;
            // TimeSpan t2 = TimeSpan.MinValue;
            // TimeSpan t3 = TimeSpan.Zero;
            // System.Console.WriteLine(t1);
            // System.Console.WriteLine(t2);
            // System.Console.WriteLine(t3);
            // TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            // System.Console.WriteLine(t);
            // System.Console.WriteLine($"Days: {t.Days}");
            // System.Console.WriteLine($"Hours: {t.Hours}");
            // System.Console.WriteLine($"Minutes: {t.Minutes}");
            // System.Console.WriteLine($"Milliseconds: {t.Milliseconds}");
            // System.Console.WriteLine($"Seconds: {t.Seconds}");
            // System.Console.WriteLine($"Ticks: {t.Ticks}");

            // System.Console.WriteLine();
            // System.Console.WriteLine($"TotalDays: {t.TotalDays}");
            // System.Console.WriteLine($"TotalHours: {t.TotalHours}");
            // System.Console.WriteLine($"TotalMinutes: {t.TotalMinutes}");
            // System.Console.WriteLine($"TotalSeconds: {t.TotalSeconds}");
            // System.Console.WriteLine($"TotalMilliseconds: {t.TotalMilliseconds}");

            //OPERACOES
            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);

            //SOMA
            TimeSpan sum = t1.Add(t2);
            System.Console.WriteLine(sum);
            //SUBTRACAO
            TimeSpan dif = t1.Subtract(t2);
            System.Console.WriteLine(dif);
            //MULTIPLICACAO
            TimeSpan mult = t2.Multiply(2.0);
            System.Console.WriteLine(mult);
            //DIVISAO
            TimeSpan div = t2.Divide(2.0);
            System.Console.WriteLine(div);
        }
    }
}
