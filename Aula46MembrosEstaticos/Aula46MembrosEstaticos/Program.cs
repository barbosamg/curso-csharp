using System;
using System.Globalization;

namespace Aula46MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Calculadora calculadora = new Calculadora();

            Console.WriteLine("Digite o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = calculadora.Cinrcunferencia(raio);
            double volume = calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circunferencia.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Pi: {calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();*/

            //SEM INSTANCIAS COM METODOS ESTATICOS DA CALCULADORA
            Console.WriteLine("Digite o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = Calculadora.Cinrcunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circunferencia.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Pi: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();

        }
    }
}
