using System;
using System.Collections.Generic;
using System.Text;
using ExercicioFixacao.Entites.Exceptions;

namespace ExercicioFixacao
{
    class Account
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Account()
        {

        }
        public Account(int numero, string titular, double saldo, double limiteSaque)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            if(Saldo == 0 || valor > LimiteSaque)
            {
                throw new DomainException("Você não pode efetuar este saque! O saque é maior que seu limite" +
                    "ou você não possui saldo suficiente.");
            }
            Saldo -= valor;
        }
    }
}
