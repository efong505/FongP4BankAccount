using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace FongP4BankAccount
{
    class BankAccount
    {

        // parameterless chained constructor
        public BankAccount() : this("", 0, 0.0M) { }
        // overloaded constructor
        public BankAccount(string name, int accountNum, decimal savingsAccountBalanace)
        {
            Name = name;
            AccountNum = accountNum;
            Balance = savingsAccountBalanace;
        }
        // Name Property
        public string Name 
        { 
            get=>_name; 
            set { _name = value; } 
        }
        private string _name; // backing field for name

        // Account Number Property
        public int AccountNum
        {
            get => _accountNum;
            set { _accountNum = value; }
        }
        private int _accountNum; // backing field for account number
        // Balance Property
        public decimal Balance 
        { 
            get=>_savingsAccountBalance;
            set { _savingsAccountBalance = value; } 
        }
        private decimal _savingsAccountBalance; // Balance backing field

       
        
        // virtual function Deposit
        public virtual void Deposit(decimal deposit)
        {
            Balance += deposit;
            
        }
        
        // virtual function Withdraw
        public virtual void Withdraw(decimal withdraw)
        {
            if (Balance - withdraw >= 0)
                Balance -= withdraw;
            else
                throw new WithrawlExceptionHandle();
        }

        public override string ToString()
        {
            
            return "Name: "+ Name + "\r\nSavings Acct: " +  
                " " + AccountNum + "\r\nBalance: " + Balance.ToString("C");
        } 
    }
   

}
