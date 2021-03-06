﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//TODO:  You are doing all of the deposit/withdraw -5
//TODO:  transactions in the derived classes.  The inheritance idea is to 
//TODO:  let the base class, which has already the "basic" functionality do it.
//TODO:  The only things calculated by the derived classes are the fees.
//TODO:  That is why you keep on throwing the exceptions in each class.
//TODO:  You never get to the base class to let it throw it.

namespace FongP4BankAccount
{
    // BankAccountForm class
    /// <summary>
    /// BankAccountForm class inherits from <c>Form</c>
    /// </summary>
    public partial class BankAccountForm : Form
    {
        // Error and Success messages strings
        /// <summary>
        /// readonly error string messages for popup and text error and success messages 
        /// </summary>
        // Success message for account page
        readonly string successMess = "Great! Thanks, Please proceed to Deposit/Withdraw Tab";

        // Error message for popup
        readonly string errorPopUp = "You've entered an invalid number type. \r\nPlease try again.";

        // Error Message text
        readonly string errorText = "ERROR!!! You have entered in invalid response above";



        // Bank account array to hold 3 account types
        /// <summary>
        /// Bank account array to hold the 3 account types
        /// </summary>
        BankAccount[] bankAccount = new BankAccount[3];
        
        // form initializer
        /// <summary>
        /// form initializer
        /// </summary>
        public BankAccountForm()
        { 
            InitializeComponent();
        }

        // Event handler for button update on account tab on the form
        /// <summary>
        /// button update event handler that instantiates the 3 bank types
        /// and handles the entries of the account data information from the user 
        /// placing them into their properties and/or calls their appropriate methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            // set the success and error messages
            correctEntryStatus.Text = successMess; // set success message into correct message label
            IncorrectEntry.Text = errorText; // set error message into incorrect message lable

            // Create object for BankAccount 
            BankAccount savings = new BankAccount("bankAccountOwner",
                101, 500.00M);
            // Create object for SilverBankAccount
            SilverBankAccount silver = new SilverBankAccount("silverAcctOwner",
                201, 1500.00M, 12345, 2345);
            // Create object for GoldBankAccount
            GoldBankAccount gold = new GoldBankAccount("goldAcctOwner",
                301, 25000.00M, 34567, 3210, 5M);
            
            // Place bank account objects in bankAccount array
            bankAccount[0] = savings;
            bankAccount[1] = silver;
            bankAccount[2] = gold;

            SilverBankAccount dCSilver = (SilverBankAccount)bankAccount[1];
            GoldBankAccount dCGold = (GoldBankAccount)bankAccount[2];
            
           

            // Strings of account number from text box fields on Account Tab on form
            string accountNum = txtAccountNum.Text;
            
            //Switch that handles the combo box user choice to 
            // select the appropropriate bank account types. 
            switch (comBAcctType.Text)
            {
                case "SavingAcct":
                    // Name of customer
                    bankAccount[0].Name = txtBName.Text;
                    
                    // TryParse account number 
                    bool acctNum = Int32.TryParse(accountNum, out int accountNumber);
                    
                    // if valid, set account number to AccountNum property 
                    if (acctNum)
                    {
                        // message displayed if entries are correct
                        bankAccount[0].AccountNum = accountNumber;
                        
                        // message if valid and instruction to proceed
                        IncorrectEntry.Visible = false; // hide the error message  
                        correctEntryStatus.Visible = true; // Show the success message
                    }
                    // if incorrect display error message in popup
                    else
                    {
                        // error message 
                        IncorrectEntry.Visible = true;
                        correctEntryStatus.Visible = false;

                        // Popup that displays error message
                        MessageBox.Show(errorPopUp,
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
                   
                    string atmAccountNum = txtBATMAcctNum.Text;
                    string atmPin = txtBATMPin.Text;
                    
                    
                   

                    // Checks for TryParse
                    bool atmAcctNum = Int32.TryParse(atmAccountNum, out int atmAccountNumber);
                    bool ATMPin = Int32.TryParse(atmPin, out int atmPinNum);
                    
                    if (atmAcctNum && ATMPin)
                    {
                        // Concatinate atmAccountNum and ATM Pin
                        accountNum = atmAccountNum + atmPin;
                        Int32.TryParse(accountNum, out accountNumber);


                        txtAccountNum.Text = accountNum;
                        
                        
                        bankAccount[1].AccountNum = accountNumber;

                        dCSilver.ATMAccountNum = atmAccountNumber;
                        dCSilver.Pin = atmPinNum;

                        // TODO:First way downcasted SilverBankAccount
                        //((SilverBankAccount)bankAccount[1]).ATMAccountNum = atmAccountNumber;
                        //((SilverBankAccount)bankAccount[1]).Pin = atmPinNum;
                        
                        // message on status of entries made
                        IncorrectEntry.Visible = false;
                        correctEntryStatus.Visible = true;
                    }
                    else
                    {
                        // message if incorrect entries
                        IncorrectEntry.Visible = true;
                        correctEntryStatus.Visible = false;

                        // Popup that displays error message
                        MessageBox.Show(errorPopUp,
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
                    atmAccountNum = txtBATMAcctNum.Text;
                    atmPin = txtBATMPin.Text;
                    string intRte = txtBInterstRate.Text;

                    
                    atmAcctNum = Int32.TryParse(atmAccountNum, out atmAccountNumber);
                    ATMPin = Int32.TryParse(atmPin, out atmPinNum);
                    bool intRate = Decimal.TryParse(intRte, out Decimal interestRate);

                    if (atmAcctNum && ATMPin && intRate)
                    {
                        
                        // Concatinate atmAccountNum and ATM Pin
                        txtAccountNum.Text = atmAccountNum + atmPin;
                        accountNum = txtAccountNum.Text;
                        // Checks for TryParse
                        Int32.TryParse(accountNum, out accountNumber);

                        dCGold.ATMAccountNum = accountNumber;
                        dCGold.Pin = atmPinNum;
                        dCGold.Interest = interestRate;

                        bankAccount[2].AccountNum = accountNumber;

                        //TODO: 1st way downcasted for GoldBankAccount
                        //((GoldBankAccount)bankAccount[2]).ATMAccountNum = atmAccountNumber;
                        //((GoldBankAccount)bankAccount[2]).Pin = atmPinNum;
                        //((GoldBankAccount)bankAccount[2]).Interest = interestRate;
                        
                        // entries if entered correctly
                        IncorrectEntry.Visible = false;
                        correctEntryStatus.Visible = true;
                    }
                    else
                    {
                        //message if entries entered incorrectly
                        IncorrectEntry.Visible = true;
                        correctEntryStatus.Visible = false;

                        // Popup that displays error message
                        MessageBox.Show(errorPopUp,
                        "Invalid Number",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    }
                    break;
            }
        }

        // event handler button click for processing transactions on transactions tab
        /// <summary>
        /// Handles the process of transaction process button handler. 
        /// Calls the methods calculate transaction and places values into class properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnProcessTrans_Click(object sender, EventArgs e)
        {
            switch (comBAcctType.Text)
            {
                case "SavingAcct":

                    string amount = txtBAmount.Text;
                    // Check for TryParse
                    bool amountCheck = Decimal.TryParse(amount, out decimal amountTrans);

                    // if valid set account number to AccountNum property 
                    if (amountCheck)
                    {
                        // check if deposit or withdrawl
                        if(rdBDeposit.Checked)
                        {
                            bankAccount[0].Deposit(amountTrans);
                            txtResults.Text = bankAccount[0].ToString();
                            lstBTransactions.Items.Add("Deposited $" + amountTrans +
                                " to account " + bankAccount[0].AccountNum);
                        }
                        else if(rdBWithdraw.Checked)
                        {
                            try 
                            { 
                            bankAccount[0].Withdraw(amountTrans);
                            txtResults.Text = bankAccount[0].ToString();
                            lstBTransactions.Items.Add("Withdrew $" + amountTrans +
                                " from account " + bankAccount[0].AccountNum);
                            }
                            catch (Exception exc)
                            {
                                txtResults.Text = exc.Message;   
                            }
                        }
                        
                    }
                    // if incorrect display error message in popup
                    else
                    {
                        // text error message into results text box
                        txtResults.Text = "Invalid Number Type";
                        // Popup that displays error message
                        MessageBox.Show(errorPopUp,
                        "Invalid Number",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    }
                    break;

                case "SilverAcct":
                    amount = txtBAmount.Text;
                    // Check for TryParse
                    amountCheck = Decimal.TryParse(amount, out  amountTrans);

                    // if valid set account number to AccountNum property 
                    if (amountCheck)
                    {
                        // check if deposit or withdrawl
                        if (rdBDeposit.Checked)
                        {
                            bankAccount[1].Deposit(amountTrans);
                            txtResults.Text = bankAccount[1].ToString();
                            lstBTransactions.Items.Add("Deposited $" + amountTrans +
                                " to account " + bankAccount[1].AccountNum);
                        }
                        else if (rdBWithdraw.Checked)
                        {
                            try
                            { 
                                bankAccount[1].Withdraw(amountTrans);
                                txtResults.Text = bankAccount[1].ToString();
                                lstBTransactions.Items.Add("Withdrew $" + amountTrans +
                                    " from account " + bankAccount[1].AccountNum);
                            }
                            catch (Exception exc)
                            {
                                txtResults.Text = exc.Message;
                            }
                        }
                    }
                    // if incorrect display error message in popup
                    else
                    {

                        // text error message into results text box
                        txtResults.Text = "Invalid Number Type";

                        // Popup that displays error message
                        MessageBox.Show(errorPopUp,
                        "Invalid Number",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    }
                    break;

                case "GoldAcct":

                    amount = txtBAmount.Text;
                    // Check for TryParse
                    amountCheck = Decimal.TryParse(amount, out  amountTrans);

                    // if valid set account number to AccountNum property 
                    if (amountCheck)
                    {
                        // check if deposit or withdrawl
                        if (rdBDeposit.Checked)
                        {
                            bankAccount[2].Deposit(amountTrans);
                            txtResults.Text = bankAccount[2].ToString();
                            lstBTransactions.Items.Add("Deposited $" + amountTrans +
                                " to account " + bankAccount[2].AccountNum);
                        }
                        else if (rdBWithdraw.Checked)
                        {
                            try
                            { 
                                bankAccount[2].Withdraw(amountTrans);
                                txtResults.Text = bankAccount[2].ToString();
                                lstBTransactions.Items.Add("Withdrew $" + amountTrans +
                                    " from account " + bankAccount[2].AccountNum);
                            }
                            catch (Exception exc)
                            {
                                txtResults.Text = exc.Message;
                            }
                        }
                    }

                    // if incorrect display error message in popup
                    else
                    {

                        // text error message into results text box
                        txtResults.Text = "Invalid Number Type";

                        // Popup that displays error message
                        MessageBox.Show(errorPopUp,
                        "Invalid Number",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    }
                    break;
            }
        }

        // ComboBox - Change state of account types - Hides fields and textboxes 
        // in correlation to it's account type
        /// <summary>
        /// Handles the combobox show and hide labels and text fields according to the users
        /// choice of bank account types. 
        /// </summary>
        /// <remarks>
        /// shows pin and atm account number for silver and interest label and text field for gold.
        /// also hides the above when basic bank account is selected.
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ComBAcctType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comBAcctType.Text)
            {
                case "SavingAcct":
                    lblATMPin.Visible = false;
                    txtBATMPin.Visible = false;
                    txtAccountNum.ReadOnly = false;
                    lblPercentRate.Visible = false;
                    txtBInterstRate.Visible = false;
                    lblATMAcctNum.Visible = false;
                    txtBATMAcctNum.Visible = false;
                    break;
                case "SilverAcct":
                    lblATMAcctNum.Visible = true;
                    txtBATMAcctNum.Visible = true;
                    txtAccountNum.Text = "";
                    txtAccountNum.ReadOnly = true;
                    lblATMPin.Visible = true;
                    txtBATMPin.Visible = true;
                    lblPercentRate.Visible = false;
                    txtBInterstRate.Visible = false;
                    break;
                case "GoldAcct":
                    lblATMAcctNum.Visible = true;
                    txtBATMAcctNum.Visible = true;
                    txtAccountNum.Text = "";
                    txtAccountNum.ReadOnly = true;
                    lblATMPin.Visible = true;
                    txtBATMPin.Visible = true;
                    lblPercentRate.Visible = true;
                    txtBInterstRate.Visible = true;
                    break;
            }
        }

        // Clear button - event handler to clear fields on transaction tab
        /// <summary>
        /// Clears all fields on the deposit/withdraw tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtBAmount.Text = "";
            lstBTransactions.Items.Clear();
            txtResults.Text = "";
        }
    }
}
