using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    /// <summary>
    /// Inherits from the Form class and makes the interface for the user.
    /// Author: Nigel Mansell
    /// Date: 2/12/17
    /// </summary>
    public partial class Form1 : Form
    {
        // Fields
        decimal balance = 0.00m;
        decimal interest = 0.00m;
        decimal fee = 0.00m;
        decimal amount = 0.00m;
        decimal interestAdded = 0.00m;
        decimal interestAmount = 0.00m;
        checkingAccount checking;
        Account account;
        savingsAccount savings;
        
        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        
        }


        /// <summary>
        /// Changes labels 
        /// </summary>
        /// <param name="sender"> see classSystem.Object api </param>
        /// <param name="e"> see classSystem.EcentArgs api</param>
        private void accountRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(accountRadioButton.Checked)
            {
                balance = 0.00m;
                amount = 0.00m;
                fee = 0.00m;
                interest = 0.00m;
                depositLabel.Text = "Deposit amount for account";
                accountBalanceBox.Text = "$0.00";
                amountBox.Text = "0.00";
                balanceBox.Text = "";
                checkingBalanceBox.Text = "$0.00";
                feeBox.Text = "";
                interestBox.Text = "";
                savingsBalanceBox.Text = "$0.00";
                interestButton.Visible = false;
                interestBox.Visible = false;
                feeBox.Visible = false;
            }
        }

        /// <summary>
        /// Changes labels
        /// </summary>
        /// <param name="sender"> see classSystem.Object api </param>
        /// <param name="e"> see classSystem.EcentArgs api</param>
        private void checkingRadioButton_CheckedChanged(object sender, EventArgs e)
        {


            if (checkingRadioButton.Checked)
            {
                balance = 0.00m;
                amount = 0.00m;
                fee = 0.00m;
                interest = 0.00m;
                depositLabel.Text = "Deposit amount for checking";
                accountBalanceBox.Text = "$0.00";
                amountBox.Text = "0.00";
                balanceBox.Text = "";
                checkingBalanceBox.Text = "$0.00";
                feeBox.Text = "";
                interestBox.Text = "";
                savingsBalanceBox.Text = "$0.00";
                interestButton.Visible = false;
                interestBox.Visible = false;
                feeBox.Visible = true;
            }
       
        }

        /// <summary>
        /// Changes labels
        /// </summary>
        /// <param name="sender"> see classSystem.Object api </param>
        /// <param name="e"> see classSystem.EcentArgs api</param>
        private void savingsRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            
            if (savingsRadioButton.Checked)
            {
                balance = 0.00m;
                amount = 0.00m;
                fee = 0.00m;
                interest = 0.00m;
                depositLabel.Text = "Deposit amount for savings";
                accountBalanceBox.Text = "$0.00";
                amountBox.Text = "0.00";
                balanceBox.Text = "";
                checkingBalanceBox.Text = "$0.00";
                feeBox.Text = "";
                interestBox.Text = "";
                savingsBalanceBox.Text = "$0.00";
                interestButton.Visible = true;
                interestBox.Visible = true;
                feeBox.Visible = false;
            }

            
        }

        /// <summary>
        /// Gets the required information from the user and then creates
        /// the object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void depositButton_Click(object sender, EventArgs e)
        {
            
            if (accountRadioButton.Checked)
            {
                balance = Convert.ToDecimal(balanceBox.Text);
                amount = Convert.ToDecimal(amountBox.Text);
                account = new Account(balance);
                accountBalanceBox.Text = account.getBalance.ToString("c");
            }

            else if (checkingRadioButton.Checked)
            {
                fee = Convert.ToDecimal(feeBox.Text);
                balance = Convert.ToDecimal(balanceBox.Text);
                checking = new checkingAccount(fee, balance);
                checkingBalanceBox.Text = checking.getBalance.ToString("c");
            }

            else if (savingsRadioButton.Checked)
            {
                balance = Convert.ToDecimal(balanceBox.Text);
                interest = Convert.ToDecimal(interestBox.Text) / 100;
                savings = new savingsAccount(interest, balance);
                savingsBalanceBox.Text = savings.getBalance.ToString("c");
            }


        }

        /// <summary>
        /// When clicked, calls the credit method for whichever account
        /// is seleced
        /// </summary>
        /// <param name="sender"> see classSystem.Object api</param>
        /// <param name="e"> see classSystem.Object api</param>
        private void creditButton_Click(object sender, EventArgs e)
        {
            if (checkingRadioButton.Checked)
            {
               
                amount = Convert.ToDecimal(amountBox.Text);
                checking.credit(amount);
                checkingBalanceBox.Text = checking.getBalance.ToString("c");
            }

            else if (accountRadioButton.Checked)
            {
                
                amount = Convert.ToDecimal(amountBox.Text);
                account.credit(amount);
                accountBalanceBox.Text = account.getBalance.ToString("c");
            }
        }

        /// <summary>
        /// When clicked, calls the debit method for whichever account
        /// is seleced
        /// </summary>
        /// <param name="sender"> see classSystem.Object api</param>
        /// <param name="e"> see classSystem.Object api</param>
        private void debitButton_Click(object sender, EventArgs e)
        {
            if (checkingRadioButton.Checked)
            {
                amount = Convert.ToDecimal(amountBox.Text);
                checking.debit(amount);
                checkingBalanceBox.Text = checking.getBalance.ToString("c");
            }

            else if (accountRadioButton.Checked)
            {
                amount = Convert.ToDecimal(amountBox.Text);
                account.debit(amount);
                accountBalanceBox.Text = account.getBalance.ToString("c");
            }
        }

        /// <summary>
        /// When clicked, calls the base credit method and 
        /// savings calculate credit
        /// </summary>
        /// <param name="sender"> see classSystem.Object api</param>
        /// <param name="e"> see classSystem.Object api</param>
        private void interestButton_Click(object sender, EventArgs e)
        {
            
            interestAmount = savings.calculateInterest();
            interestAdded = interestAmount;
            savings.credit(interestAdded);
            savingsBalanceBox.Text = savings.getBalance.ToString("c");
        }

        
    }
}
