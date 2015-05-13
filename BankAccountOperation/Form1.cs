using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountOperation
{
    public partial class bankAccountForm : Form
    {
        public bankAccountForm()
        {
            InitializeComponent();
        }
        Account anAccount = new Account();
        
        private void createButton_Click(object sender, EventArgs e)
        {
            anAccount.accountNumber = accountNumberTextBox.Text;
            anAccount.customerName = customerNameTextBox.Text;
            if (anAccount.accountNumber == "" && anAccount.customerName == "")
            {
                MessageBox.Show("Please Enter Account Number and Customer Name");
            }
            else
            {
                if (anAccount.accountNumber == "")
                {
                    MessageBox.Show("Please Enter Account Number");
                }
                else if (anAccount.customerName == "")
                {
                    MessageBox.Show("Please Enter Customer Name");
                }
                else
                MessageBox.Show("Account Created Successfully!");
            }
            accountNumberTextBox.Clear();
            customerNameTextBox.Clear();

          // MessageBox.Show("Account Number " + anAccount.accountNumber + ", Customer Name " + anAccount.customerName + " Created Succesfully");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (anAccount.accountNumber != "")
            {
                anAccount.amount = Convert.ToDouble(amountTextBox.Text);
                anAccount.balance += anAccount.amount;
               MessageBox.Show("Tk." + anAccount.amount + "Has Deposited Succesfully, and Current Balance is Tk." +anAccount.balance );
            }
            else
                MessageBox.Show("Please Enter a Valid Account Number");
            
                     
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            anAccount.amount = Convert.ToDouble(amountTextBox.Text);

            if (anAccount.accountNumber != "")
            {
                if (anAccount.balance < anAccount.amount)
                {
                    MessageBox.Show("Insufficient Balance");

                }
                else
                {
                    anAccount.balance -= anAccount.amount;
                    MessageBox.Show("Tk." + anAccount.amount + " Has Withdrawan Succesfully, and Remaining Balance is Tk." +anAccount.balance );
                } 
            }
            else
                MessageBox.Show("Please Enter a Valid Account Number");                     
          
        }

                private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Name: " +anAccount.customerName + ", " + "Your account number: " + anAccount.accountNumber + " and its balance: " + anAccount.balance + " taka");
        }
    }
}
