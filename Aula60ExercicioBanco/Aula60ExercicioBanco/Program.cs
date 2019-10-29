using System;
using System.Globalization;

namespace Aula60ExercicioBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================= PROGRAMA CAIXA ELETRÔNICO =============================");
            Console.WriteLine();

            CaixaEletronico caixaEletronico;

            Console.Write("Número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Titular da conta: ");
            string titularConta = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char opcaoDepositoInicial = char.ToLower(char.Parse(Console.ReadLine()));

            if (opcaoDepositoInicial == 's')
            {
                Console.Write("Entre com o valor de deposito inicial: ");
                double saldo = double.Parse(Console.ReadLine());

                caixaEletronico = new CaixaEletronico(numeroConta, titularConta, saldo);
                Console.WriteLine("-----------------------------Dados da conta-----------------------------");
                Console.WriteLine($"{caixaEletronico}");
            }
            else
            {
                caixaEletronico = new CaixaEletronico(numeroConta, titularConta);
                Console.WriteLine("-----------------------------Dados da conta-----------------------------");
                Console.WriteLine($"{caixaEletronico}");
            }
            

            Console.WriteLine("______________________________________________________________________________________");

            Console.Write("Entre com um valor para depósito: ");
            double valorDepositado = double.Parse(Console.ReadLine());
            caixaEletronico.Depositar(valorDepositado);
            Console.WriteLine("-----------------------------Dados da conta atualizados-----------------------------");
            Console.WriteLine($"{caixaEletronico}");

            Console.WriteLine("______________________________________________________________________________________");

            Console.Write("Entre com um valor para saque: ");
            double valorSacado = double.Parse(Console.ReadLine());
            caixaEletronico.Sacar(valorSacado);
            Console.WriteLine("-----------------------------Dados da conta atualizados-----------------------------");
            Console.WriteLine($"{caixaEletronico}");
        }
    }
}
