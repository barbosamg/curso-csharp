using System;

namespace Aula94DateTimeKind
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime d1 = new DateTime(2000,8,15,13,5,48, DateTimeKind.Local);
            // DateTime d2 = new DateTime(2000,8,15,13,5,48, DateTimeKind.Utc);
            // DateTime d3 = new DateTime(2000,8,15,13,5,48);
            // System.Console.WriteLine($"d1: {d1}");
            // System.Console.WriteLine($"d1 kind: {d1.Kind}");
            // System.Console.WriteLine($"d1 to local: {d1.ToLocalTime()}");
            // System.Console.WriteLine($"d1 utc: {d1.ToUniversalTime()}");

            // System.Console.WriteLine();
            // System.Console.WriteLine($"d2: {d2}");
            // System.Console.WriteLine($"d2 kind: {d2.Kind}");
            // System.Console.WriteLine($"d2 to local: {d2.ToLocalTime()}");
            // System.Console.WriteLine($"d2 utc: {d2.ToUniversalTime()}");

            // System.Console.WriteLine();
            // System.Console.WriteLine($"d3: {d3}");
            // System.Console.WriteLine($"d3 kind: {d3.Kind}");
            // System.Console.WriteLine($"d3 to local: {d3.ToLocalTime()}");
            // System.Console.WriteLine($"d3 utc: {d3.ToUniversalTime()}");

            //PADRAO ISO 8601 FORMATO: yyyy-MM-ddTHH:mm:ssZ Z indica q a data/hora está em UTC
            DateTime d1 = DateTime.Parse("2000-08-23 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-25T13:05:30Z");
            System.Console.WriteLine(d1);
            System.Console.WriteLine(d2);
        }
    }
}
