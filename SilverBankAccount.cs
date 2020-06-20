using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FongP4BankAccount
{
    class SilverBankAccount: BankAccount
    {
        // Static FEES variables
        public static decimal DEPOSIT_FEE = 1.00M;
        public static decimal WITHDRAWL_FEE = 2.75M;

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
                Balance -= DEPOSIT_FEE;
                Balance += deposit;
            }
            else
            {
                Balance += deposit;
            }
        }
        //Overriden Withdrawl Method
        public override void Withdraw(decimal withdraw)
        {
            if (Balance - withdraw - WITHDRAWL_FEE >= 0)
            {
                Balance -= WITHDRAWL_FEE;
                Balance -= withdraw;
            }
            else
                throw new WithrawlExceptionHandle();
        }
        // Overriden ToString() from BankAccount class w/ ATM Account Num
        public override string ToString()
        {
            return "ATM: " + ATMAccountNum + "\r\n" + base.ToString();
        }
    }
}
