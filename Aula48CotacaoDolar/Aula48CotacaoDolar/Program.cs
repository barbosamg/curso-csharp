using System;
using System.Globalization;

namespace Aula48CotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar;
            double valorComprado;
            Console.WriteLine("Digite a cotação do dólar: ");
            dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor que você irá comprar: ");
            valorComprado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double iof = ConversorDeMoeda.CalcularIOF(valorComprado);
            double valorPago = ConversorDeMoeda.CalcularValorFinal(valorComprado,iof,dolar);

            Console.WriteLine($"Valor dólar: ${dolar} | Valor do IOF sobre o valor: R${iof} | Valor final: R${valorPago}");

            Console.ReadKey();
        }
    }
}
