using System;

namespace Aula92OperacoesDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2010,8,15,13,45,58,275);
            // System.Console.WriteLine(d);
            // System.Console.WriteLine($"Date: {d.Date}");
            // System.Console.WriteLine($"Day: {d.Day}");
            // System.Console.WriteLine($"Day of week: {d.DayOfWeek}");
            // System.Console.WriteLine($"Day of year: {d.DayOfYear}");
            // System.Console.WriteLine($"Hour: {d.Hour}");
            // System.Console.WriteLine($"Kind: {d.Kind}");
            // System.Console.WriteLine($"Millisecond: {d.Millisecond}");
            // System.Console.WriteLine($"Minute: {d.Minute}");
            // System.Console.WriteLine($"Month: {d.Month}");
            // System.Console.WriteLine($"Second: {d.Second}");
            // System.Console.WriteLine($"Ticks: {d.Ticks}");
            // System.Console.WriteLine($"TimeOfDay: {d.TimeOfDay}");
            // System.Console.WriteLine($"Year: {d.Year}");

            // System.Console.WriteLine(d.ToLongDateString());
            // System.Console.WriteLine(d.ToLongTimeString());
            // System.Console.WriteLine(d.ToShortDateString());
            // System.Console.WriteLine(d.ToShortTimeString());
            // System.Console.WriteLine(d.ToString());
            // System.Console.WriteLine(d);

            //MASCAR DE FORMATAÇÃO
            // string d2 = d.ToString("yyyy-MM-dd HH:mm:ss");
            // string d3 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            // System.Console.WriteLine(d2);
            // System.Console.WriteLine(d3);

            //OPERACOES
            DateTime d1 = DateTime.Now;
            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(5);
            DateTime d4 = d1.AddDays(7);
            System.Console.WriteLine(d);
            System.Console.WriteLine(d2);
            System.Console.WriteLine(d3);
            System.Console.WriteLine($"{d1} {d4}");
            //DIFERENCA ENTRE AS DATA
            DateTime data1 = new DateTime(2005,10,15);
            DateTime data2 = new DateTime(2005,10,25);
            TimeSpan t = data2.Subtract(data1);
            System.Console.WriteLine(t);
        }
    }
}
