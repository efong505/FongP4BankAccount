using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace FongP4BankAccount
{
    /// <summary>
    /// The GoldBank Account Class that Inherits from the SilverBankAccount
    /// </summary>
    class GoldBankAccount :SilverBankAccount
    {
        /// <summary>
        /// GoldBankAccount constructor that inherits from the base class SilverBankAccount
        /// that includes everything from the base and the SilverBankAccount class but
        /// adds interest to the constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="accountNum"></param>
        /// <param name="savingsAccountBalanace"></param>
        /// <param name="atmAccountNum"></param>
        /// <param name="pin"></param>
        /// <param name="interest"></param>
        public GoldBankAccount(string name, int accountNum,
            decimal savingsAccountBalanace, int atmAccountNum, int pin, decimal interest)
            : base(name,accountNum,savingsAccountBalanace,atmAccountNum,pin)
        {
            Interest = interest;
        }
        /// <summary>
        /// Interst property
        /// </summary>
        // Interest property
        public decimal Interest {
            get => _interest;
            set 
            {
                // return percentage in decimal of the number 
                //entered on the form
                _interest =  value/100;
                
            } 
        }
        decimal _interest;// Interest backing field

        /// <summary>
        /// DepositBool boolean checks if the transaction is a deposit or if it's a withdrawl.
        /// If the boolean returns true then it's a Deposit. False, it's a Withdrawl.
        /// </summary>
        // Deposit bool Property if true then transaction is a deposit
        // if false, withrawl is the transaction
        public bool DepositBool { get; set; }
        
        /// <summary>
        /// Overriden Withdraw method that checks to see if the balance is equal or greater than 20,000. 
        /// If it is then it withdraws the withdrawl amount from the balance without any fees updating the balance
        /// amount.
        /// If the balance is less than 20,000 then the withdrawl fee defaults to the SilverBankAccount class,
        /// if the balance is under 5,000 than the withdrwal fee is 2.75.
        /// The method also checks to see if the withdrawl fee will overdraft the account.
        /// If it will, it calls the WithdrawlExcptionHandle class and display, "Insufficient Funds".
        /// <param name="withdraw"></param>
        public override void Withdraw(decimal withdraw)
        {
            if(Balance >= 20000)
            {
                Balance -= withdraw;
                DepositBool = false;
            }
            else
            {
                if (Balance - withdraw - WITHDRAWL_FEE >= 0)
                {
                    base.Withdraw(withdraw); 
                    DepositBool = false;
                }
                else
                    throw new WithrawlExceptionHandle();

            }
        }
        /// <summary>
        /// Overriden Deposit method that adds interest to the account if the balance is equal to or greater
        /// than 5,000. If the balance is less than 5,000 then the depsosit fees are defaulted to the SilverBankAccount
        /// </summary>
        /// <param name="deposit"></param>
        public override void Deposit(decimal deposit)
        {
            if(Balance >= 5000)
            {
                Balance += Balance * Interest; // add interest to balance
                Balance += deposit;
                DepositBool = true;
            }
            else
            {
                //Balance += DepositProp;
                base.Deposit(deposit);
                DepositBool = true;
            }
        }
        /// <summary>
        /// Overriden To String
        /// </summary>
        /// <returns>
        /// Returns the bank account number, name and balance from the base ToString() method and adds the interest
        /// rate an amount if it's a deposit and ommits the interest information if it's a withdrawl.
        /// </returns>
        public override string ToString()
        {
              decimal interestTotal = Interest * Balance;
            if(DepositBool)
            return base.ToString() + "\r\nInterest rate: " + Interest.ToString("P1") +
                "\r\nInterest: " + interestTotal.ToString("C");
            else
                return base.ToString();
        }

    }
}
