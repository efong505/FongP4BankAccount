using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FongP4BankAccount
{
    class GoldBankAccount :SilverBankAccount
    {
        public GoldBankAccount(string name, int accountNum,
            decimal savingsAccountBalanace, int atmAccountNum, int pin, decimal interest)
            : base(name,accountNum,savingsAccountBalanace,atmAccountNum,pin)
        {
            Interest = interest;
        }

        // Interest property
        public decimal Interest { 
            get=>_interest; 
            set 
            {
                // return percentage in decimal of the number 
                //entered on the form - divide by 100
                _interest *= 100; 
            } 
        }
        decimal _interest;// Interest backing field

        public override void Withdraw(decimal withdrawl)
        {
            if(Balance >= 20000)
            {
                Balance += withdrawl;
            }
            else
            {
                base.Withdraw(withdrawl);
            }
        }
        public override void Deposit(decimal deposit)
        {
            if(Balance >= 5000)
            {
                Balance *= Interest;
                Balance += deposit;
            }
            else
            {
                base.Deposit(deposit);
            }
        }
        public override string ToString()
        {
            return base.ToString() + " interest: " + Interest;
        }

    }
}
