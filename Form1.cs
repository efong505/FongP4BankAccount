using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FongP4BankAccount
{
    public partial class BankAccountForm : Form
    {
        // Bank account array to hold 3 account types
        BankAccount[] bankAccount = new BankAccount[3];
        
        public BankAccountForm()
        { 
            InitializeComponent();
        }

        // Event handler for button update on account tab
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            // Create objects for each account type
            BankAccount savings = new BankAccount("bankAccountOwner",
                101, 500.00M);
            SilverBankAccount silver = new SilverBankAccount("silverAcctOwner",
                201, 1500.00M, 12345, 2345);
            GoldBankAccount gold = new GoldBankAccount("goldAcctOwner",
                301, 25000.00M, 34567, 3210, .05M);
            
            // Place objects in bankAccount array
            bankAccount[0] = savings;
            bankAccount[1] = silver;
            bankAccount[2] = gold;

           
            // Strings of numbers from text box fields
            string accountNum = txtAccountNum.Text;

            switch (comBAcctType.Text)
            {
                case "SavingAcct":
                    // Name of customer
                    bankAccount[0].Name = txtBName.Text;
                    
                    // Check for TryParse
                    bool acctNum = Int32.TryParse(accountNum, out int accountNumber);
                    
                    // if valid set account number to AccountNum property 
                    if (acctNum)
                    {
                        // message displayed if entries are correct
                        bankAccount[0].AccountNum = accountNumber;
                        
                        // message to proceed
                        IncorrectEntry.Text = "";
                        IncorrectEntry.Visible = false;
                        correctEntryStatus.Text = "Great! Thanks, Please proceed to Deposit/Withdraw Tab";
                        correctEntryStatus.Visible = true;
                    }
                    // if incorrect display error message in popup
                    else
                    {
                        // error message 
                        IncorrectEntry.Text = "ERROR!!! You have entered in invalid response above";
                        IncorrectEntry.Visible = true;
                        correctEntryStatus.Text = "";
                        correctEntryStatus.Visible = false;

                        // Popup that displays error message
                        MessageBox.Show("You've entered an invalid number type. \r\nPlease try again.",
                        "Invalid Number",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);

                        
                    }                 
                    break;
                
                case "SilverAcct":
                    // Name of customer
                    bankAccount[1].Name = txtBName.Text;

                    // Strings of numbers from text box fields
                    accountNum = txtAccountNum.Text;
                    string atmAccountNum = txtBATMAcctNum.Text;
                    string atmPin = txtBATMPin.Text;
                    //string intRte = txtBInterstRate.Text;

                    // Checks for TryParse
                    acctNum = Int32.TryParse(accountNum, out accountNumber);
                    bool atmAcctNum = Int32.TryParse(atmAccountNum, out int atmAccountNumber);
                    bool ATMPin = Int32.TryParse(atmPin, out int atmPinNum);
                   // bool intRate = Decimal.TryParse(intRte, out Decimal interestRate);

                    if (acctNum && atmAcctNum && ATMPin)
                    { 
                        bankAccount[1].AccountNum = accountNumber;
                        ((SilverBankAccount)bankAccount[1]).ATMAccountNum = atmAccountNumber;
                        ((SilverBankAccount)bankAccount[1]).Pin = atmPinNum;
                        
                        // message on status of entries made
                        IncorrectEntry.Text = "";
                        IncorrectEntry.Visible = false;
                        correctEntryStatus.Text = "Great! Thanks, Please proceed to Deposit/Withdraw Tab";
                        correctEntryStatus.Visible = true;
                    }
                    else
                    {
                        // message if incorrect entries
                        IncorrectEntry.Text = "ERROR!!! You have entered in invalid response above";
                        IncorrectEntry.Visible = true;
                        correctEntryStatus.Text = "";
                        correctEntryStatus.Visible = false;

                        // Popup that displays error message
                        MessageBox.Show("You've entered an invalid number type. \r\nPlease try again.",
                        "Invalid Number",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    }


                    break;
                case "GoldAcct":
                    // Name of customer
                    bankAccount[2].Name = txtBName.Text;

                    // Strings of numbers from text box fields
                    accountNum = txtAccountNum.Text;
                    atmAccountNum = txtBATMAcctNum.Text;
                    atmPin = txtBATMPin.Text;
                    string intRte = txtBInterstRate.Text;

                    // Checks for TryParse
                    acctNum = Int32.TryParse(accountNum, out accountNumber);
                    atmAcctNum = Int32.TryParse(atmAccountNum, out atmAccountNumber);
                    ATMPin = Int32.TryParse(atmPin, out atmPinNum);
                    bool intRate = Decimal.TryParse(intRte, out Decimal interestRate);

                    if (acctNum && atmAcctNum && ATMPin && intRate)
                    { 
                        bankAccount[2].AccountNum = accountNumber;
                        ((GoldBankAccount)bankAccount[2]).ATMAccountNum = atmAccountNumber;
                        ((GoldBankAccount)bankAccount[2]).Pin = atmPinNum;
                        ((GoldBankAccount)bankAccount[2]).Interest = interestRate;
                        
                        // entries if entered correctly
                        IncorrectEntry.Text = "";
                        IncorrectEntry.Visible = false;
                        correctEntryStatus.Text = "Great! Thanks, Please proceed to Deposit/Withdraw Tab";
                        correctEntryStatus.Visible = true;
                    }
                    else
                    {
                        //message if entries entered incorrectly
                        IncorrectEntry.Text = "ERROR!!! You have entered in invalid response above";
                        IncorrectEntry.Visible = true;
                        correctEntryStatus.Text = "";
                        correctEntryStatus.Visible = false;

                        // Popup that displays error message
                        MessageBox.Show("You've entered an invalid number type. \r\nPlease try again.",
                        "Invalid Number",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    }
                    break;
            }
        }

        // event handler button click for processing transactions on transactions tab
        private void btnProcessTrans_Click(object sender, EventArgs e)
        {
           
        }

        // Change state of account types - Hides fields and textboxes 
        // in correlation to it's account type
        private void comBAcctType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comBAcctType.Text)
            {
                case "SavingAcct":
                    lblATMPin.Visible = false;
                    txtBATMPin.Visible = false;
                    lblPercentRate.Visible = false;
                    txtBInterstRate.Visible = false;
                    lblATMAcctNum.Visible = false;
                    txtBATMAcctNum.Visible = false;
                    break;
                case "SilverAcct":
                    lblATMAcctNum.Visible = true;
                    txtBATMAcctNum.Visible = true;
                    lblATMPin.Visible = true;
                    txtBATMPin.Visible = true;
                    lblPercentRate.Visible = false;
                    txtBInterstRate.Visible = false;

                    break;
                case "GoldAcct":
                    lblATMAcctNum.Visible = true;
                    txtBATMAcctNum.Visible = true;
                    lblATMPin.Visible = true;
                    txtBATMPin.Visible = true;
                    lblPercentRate.Visible = true;
                    txtBInterstRate.Visible = true;
                    break;
            }
        }

        // Clear button event handler to clear fields on transaction tab
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBAmount.Text = "";
            txtBTransactions.Text = "";
            txtResults.Text = "";
        }
    }
}
