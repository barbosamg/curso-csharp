using System;
using ExercicioFixacao.Entites.Exceptions;
using ExercicioFixacao.Entites;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com os dados da conta bancária");
                Console.Write("Número: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Titular: ");
                string titular = Console.ReadLine();
                Console.Write("Saldo Inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                Console.Write("Limite para saque: ");
                double limiteSaque = double.Parse(Console.ReadLine());
                Account account = new Account(numero, titular, saldo, limiteSaque);

                Console.WriteLine();
                Console.Write("Digite o valor do saque: ");
                double saque = double.Parse(Console.ReadLine());
                account.Saque(saque);
                Console.WriteLine($"Novo saldo: {account.Saldo}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
    }
}
