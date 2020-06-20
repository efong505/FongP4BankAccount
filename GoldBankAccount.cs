using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
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
            get => _interest;
            set 
            {
                // return percentage in decimal of the number 
                //entered on the form
                _interest =  value/100;
                
            } 
        }
        decimal _interest;// Interest backing field

        // Deposit bool Property if true then transaction is a deposit
        // if false, withrawl is the transaction
        public bool DepositBool { get; set; }

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
