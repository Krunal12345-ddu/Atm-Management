using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ServiceModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMCLIENTApp
{
    public partial class BALANCE : Form
    {
        public BALANCE()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BALANCE_Load(object sender, EventArgs e)
        {
            try
            {
                // Displaying the account number to ensure it's correct
                label11.Text = Class1.AccountNumber.ToString();

                // Creating a proxy to the service
                ATMCLIENTApp.ATM1.ATMWITHDRAWClient proxy = new ATMCLIENTApp.ATM1.ATMWITHDRAWClient("WSHttpBinding_IATMWITHDRAW");

                // Retrieving the balance
                int balance = proxy.get_balance(Class1.AccountNumber);

                // Displaying the balance
                label12.Text = balance.ToString();
            }
            catch (Exception ex)
            {
                // Displaying the error message in a MessageBox
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Logging the error for debugging purposes
                Console.WriteLine("Error occurred in BALANCE_Load: " + ex.ToString());
            }
        }



        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            HOME hm = new HOME();
            hm.Show();
            this.Hide();
        }
    }
}
