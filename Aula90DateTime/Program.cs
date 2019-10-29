using System;
using System.Globalization;

namespace Aula90DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataUm = DateTime.Now;
            // System.Console.WriteLine(dataUm);
            // System.Console.WriteLine(dataUm.Ticks);

            DateTime data = new DateTime(2019, 05, 11);
            DateTime data2 = new DateTime(2019, 05, 11, 20, 45, 03);
            DateTime data3 = new DateTime(2019, 05, 11, 20, 45, 03, 500);
            DateTime data4 = DateTime.Now;
            DateTime data5 = DateTime.Today;
            DateTime data6 = DateTime.UtcNow;
            // System.Console.WriteLine(data6);

            DateTime d1 = DateTime.Parse("2005-08-15");
            DateTime d2 = DateTime.Parse("2005-08-15 13:05:58");
            DateTime d3 = DateTime.Parse("15/05/2015");
            DateTime d4 = DateTime.Parse("15/05/2015 15:25:36");
            // System.Console.WriteLine(d4);

            DateTime d6 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d7 = DateTime.ParseExact("15/08/2000 13:30:48", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            System.Console.WriteLine(d7);
        }
    }
}
