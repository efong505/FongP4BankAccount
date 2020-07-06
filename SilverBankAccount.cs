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
        // constant FEES variables
        /// <summary>
        /// Constant Fees variables
        /// </summary>
        protected const decimal DEPOSIT_FEE = 1.00M;
        protected const decimal WITHDRAWL_FEE = 2.75M;

        // Constructor for the SilverBankAccount that Inherits from the base 
        // class - BankACcount class
        /// <summary>
        /// Constructor for the SilverBankAccount that Inherits from the base class - BankACcount class
        /// </summary>
        /// <param name="name">A string</param>
        /// <param name="accountNum">An integer precision number</param>
        /// <param name="savingsAccountBalanace">A decimal precision number</param>
        /// <param name="atmAccountNum">An integer precision number</param>
        /// <param name="pin">An integer precision number</param>
        public SilverBankAccount(string name, int accountNum, 
            decimal savingsAccountBalanace, int atmAccountNum, int pin)
                : base(name, accountNum, savingsAccountBalanace)
        {
            ATMAccountNum = atmAccountNum;
            Pin = pin;
        }

        // atmAccountNum Properties
        /// <summary>
        /// ATM Account Number Property
        /// </summary>
        public int ATMAccountNum 
        {
            get => _atmAccountNum;
            set { _atmAccountNum = value; } 
        }
        private int _atmAccountNum;// atmAccountNum backing field
     
        // pin properties
        /// <summary>
        /// Pin Property
        /// </summary>
        public int Pin {
            get => _pin;
            set { _pin = value; }
        }
        private int _pin;// pin backing field

        // Overriden Deposit Method
        /// <summary>
        /// Overriden Deposit Method from BankAccount class
        /// </summary>
        /// <param name="deposit">A decimal precision number</param>
        public override void Deposit(decimal deposit)
        {
            //TODO:  Don't do the transaction here, do it in the base class

            if(Balance < 1000)
            {
                Balance -= DEPOSIT_FEE;
               // Balance += deposit;
            }
            base.Deposit(Balance);
            //else
            //{
            //    Balance += deposit;
            //}
        }

        //Overriden Withdrawl Method
        /// <summary>
        /// Overriden Withraw Method from the BankAccount class
        /// </summary>
        /// <param name="withdraw">A decimal precision number</param>
        /// <returns>"Insufficient funds"</returns>
        ///<exception cref="WithrawlExceptionHandle"></exception>
        ///See <see cref="WithrawlExceptionHandle"/> to see the WithdrawlExceptionHandle method
        public override void Withdraw(decimal withdraw)
        {
            //TODO:  Once you use the case class method, it handles throwing
            //TODO:   the exception
            // check if amount will overdrwaw account, if not then proeed
            // if (Balance - withdraw - WITHDRAWL_FEE >= 0)
            // {
            withdraw += WITHDRAWL_FEE;
               // Balance -= WITHDRAWL_FEE;
                base.Withdraw(withdraw);
               // Balance -= withdraw;
           // }
            //else
            //    throw new WithrawlExceptionHandle();
        }

        // Overriden ToString() from BankAccount class w/ ATM Account Num
        /// <summary>
        /// Overriden ToString() from BankAccount class
        /// </summary>
        /// <returns>
        /// Returns the heading ATM: the atm account number and the tostring from 
        /// the BankAccount class
        /// </returns>
        public override string ToString()
        {
            return "ATM: " + ATMAccountNum + "\r\n" + base.ToString();
        }
    }
}
