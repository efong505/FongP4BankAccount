using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace FongP4BankAccount
{
    class BankAccount
    {
        /// <summary>
        /// Parameterless Constructor that chains from overloaded constructor
        /// </summary>
        // parameterless chained constructor
        public BankAccount() : this("", 0, 0.0M) { }
        /// <summary>
        /// Overloaded constructor that adds Name, Account Number, and balance
        /// </summary>
        /// <param name="name"></param>
        /// <param name="accountNum"></param>
        /// <param name="savingsAccountBalanace"></param>
        // overloaded constructor
        public BankAccount(string name, int accountNum, decimal savingsAccountBalanace)
        {
            Name = name;
            AccountNum = accountNum;
            Balance = savingsAccountBalanace;
        }
        /// <summary>
        /// Name Property
        /// </summary>
        // Name Property
        public string Name 
        { 
            get=>_name; 
            set { _name = value; } 
        }
        private string _name; // backing field for name

        /// <summary>
        /// Account Number Property
        /// </summary>
        // Account Number Property
        public int AccountNum
        {
            get => _accountNum;
            set { _accountNum = value; }
        }
        private int _accountNum; // backing field for account number

        /// <summary>
        /// Balance Property
        /// </summary>
        // Balance Property
        public decimal Balance 
        { 
            get=>_savingsAccountBalance;
            set { _savingsAccountBalance = value; } 
        }
        private decimal _savingsAccountBalance; // Balance backing field

       
        /// <summary>
        /// Deposit virtual method that adds the deposit amount to the
        /// Balance
        /// </summary>
        /// <param name="deposit"></param>
        // virtual function Deposit
        public virtual void Deposit(decimal deposit)
        {
            Balance += deposit;
            
        }
        // virtual function Withdraw
        /// <summary>
        /// Check to see if the withdrawl amount will overdraw the account. 
        /// If the account will not be overdrawn, it subrtracts the withdrawl
        /// amount from the Balance and updates the balance amound.
        /// </summary>
        /// <remarks>
        /// Calls the custom WithdrawlExceptionHandle() method
        /// which returns "Insufficient funds" if the account will be overdrown with the
        /// requested withdrawl amount from the balance.
        /// </remarks>
        /// <param name="withdraw"></param>
        /// <returns>"Insufficient funds"</returns>
        /// ///<exception cref="WithrawlExceptionHandle"></exception>
        public virtual void Withdraw(decimal withdraw)
        {
            if (Balance - withdraw >= 0)
                Balance -= withdraw;
            else
                throw new WithrawlExceptionHandle();
        }

        // Overriden ToString()
        /// <summary>
        /// Overriden custom ToString() method 
        /// </summary>
        /// <returns>
        /// Returns the Name, account number, and balance of of the account in currency format
        /// </returns>
        public override string ToString()
        {
            
            return "Name: "+ Name + "\r\nSavings Acct: " +  
                " " + AccountNum + "\r\nBalance: " + Balance.ToString("C");
        } 
    }
   

}
