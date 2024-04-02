using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMCLIENTApp
{
    public partial class LOGIN : Form
    {
       
        public LOGIN()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            ATMCLIENTApp.ATM1.ATMWITHDRAWClient proxy = new ATMCLIENTApp.ATM1.ATMWITHDRAWClient("WSHttpBinding_IATMWITHDRAW");
            int a=int.Parse(AccNumTb.Text);
            bool loginSuccess = proxy.ValidateLogin(int.Parse(AccNumTb.Text), int.Parse(PinTb.Text));
            Class1.AccountNumber = a;
           
            proxy.Close();

            
            // Store account number in session
          

            // Redirect to another page
       
            if (loginSuccess)
            {
                // Navigate to WITHDRAW.cs
                HOME hm = new HOME();
                hm.Show();
                this.Hide(); // Assuming you want to hide the current form
            }
            else
            {
                // Display message for incorrect details
                MessageBox.Show("Incorrect account number or PIN. Please try again.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ACCOUNT accountForm = new ACCOUNT();
            accountForm.Show();
            this.Hide();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
