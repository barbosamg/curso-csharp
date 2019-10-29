using System;
using System.Collections.Generic;
using System.Text;

namespace Aula126UpcastingDowncasting.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interesRate)
            : base(number, holder, balance)
        {
            InterestRate = interesRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)
        {
            Balance -= amount;
        }
        //É POSSIVEL CHAMAR A IMPLEMENTAÇÃO DA SUPERCLASE USANDO A PALAVRA BASE.
        //EXEMPLO:
        /*
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount)
            Balance -= 2.0;
        }
        */
    }
}
