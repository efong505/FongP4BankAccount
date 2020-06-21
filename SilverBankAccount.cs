using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FongP4BankAccount
{
    class SilverBankAccount: BankAccount
    {
        /// <summary>
        /// Constant Fees variables
        /// </summary>
        // constant FEES variables
        protected const decimal DEPOSIT_FEE = 1.00M;
        protected const decimal WITHDRAWL_FEE = 2.75M;

        /// <summary>
        /// Constructor for the SilverBankAccount that Inherits from the base class - BankACcount class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="accountNum"></param>
        /// <param name="savingsAccountBalanace"></param>
        /// <param name="atmAccountNum"></param>
        /// <param name="pin"></param>
        public SilverBankAccount(string name, int accountNum, 
            decimal savingsAccountBalanace, int atmAccountNum, int pin)
                : base(name, accountNum, savingsAccountBalanace)
        {
            ATMAccountNum = atmAccountNum;
            Pin = pin;
        }
        /// <summary>
        /// ATM Account Number Property
        /// </summary>
        // atmAccountNum Properties
        public int ATMAccountNum 
        {
            get => _atmAccountNum;
            set { _atmAccountNum = value; } 
        }
        private int _atmAccountNum;// atmAccountNum backing field
        /// <summary>
        /// Pin Property
        /// </summary>
        // pin properties
        public int Pin {
            get => _pin;
            set { _pin = value; }
        }
        private int _pin;// pin backing field

        /// <summary>
        /// Overriden Deposit Method from BankAccount class
        /// </summary>
        /// <param name="deposit"></param>
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
        /// <summary>
        /// Overriden Withraw Method from the BankAccount class
        /// </summary>
        /// <param name="withdraw"></param>
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
        /// <summary>
        /// Overriden ToString() from BankAccount class
        /// </summary>
        /// <returns>
        /// Returns the heading ATM: the atm account number and the tostring from 
        /// the BankAccount class
        /// </returns>
        // Overriden ToString() from BankAccount class w/ ATM Account Num
        public override string ToString()
        {
            return "ATM: " + ATMAccountNum + "\r\n" + base.ToString();
        }
    }
}
