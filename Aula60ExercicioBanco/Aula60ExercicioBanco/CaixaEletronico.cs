using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aula60ExercicioBanco
{
    class CaixaEletronico
    {
        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }
        public double Saldo { get; private set; }

        public CaixaEletronico(int numeroConta, string titularConta, double saldo = 0)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
            Depositar(saldo);
        }

        public void Depositar(double pDeposito)
        {
            Saldo += pDeposito;
        }

        public void Sacar(double pSaque)
        {
            Saldo -= pSaque + 5.0;
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta} | Titular: {TitularConta} | Saldo: R${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
