using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FongP4BankAccount
{
    class SilverBankAccount: BankAccount
    {
        public SilverBankAccount(string name, int accountNum, 
            decimal savingsAccountBalanace, int atmAccountNum, int pin) 
            :base(name,accountNum, savingsAccountBalanace)
        {
            ATMAccountNum = atmAccountNum;
            Pin = pin;
        }
        // atmAccountNum Properties
        public int ATMAccountNum 
        { 
            get=>_atmAccountNum;
            set { _atmAccountNum = value; } 
        }
        private int _atmAccountNum;// atmAccountNum backing field
        // pin properties
        public int Pin { 
            get=>_pin;
            set {_pin = value; } 
        }
        private int _pin;// pin backing field
        // Overriden Deposit Method
        public override void Deposit(decimal deposit)
        {
            if(Balance < 1000)
            {
                Balance += deposit + 1.00M;
            }
            else
            {
                Balance += deposit;
            }
        }
        //Overriden Withdrawl Method
        public override void Withdraw(decimal withdrawl)
        {
            Balance -= 2.50M;
            Balance -= withdrawl;
        }
        // Overriden ToString() from BankAccount class w/ ATM Account Num
        public override string ToString()
        {
            return "ATM: " + ATMAccountNum + "\n" + base.ToString();
        }
    }
}
