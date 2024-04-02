using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMCLIENTApp
{
    public partial class WITHDRAW : Form
    {
        public WITHDRAW()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ATMCLIENTApp.ATM1.ATMWITHDRAWClient proxy = new ATMCLIENTApp.ATM1.ATMWITHDRAWClient("WSHttpBinding_IATMWITHDRAW");

            // Retrieving the balance
            int balance = proxy.get_balance(Class1.AccountNumber);

            if (balance > int.Parse(WithdrawTb.Text))
            {
                ATMCLIENTApp.Transaction.TransactionClient proxy1 = new ATMCLIENTApp.Transaction.TransactionClient("WSHttpBinding_ITransaction");
                proxy1.withdrawamount(Class1.AccountNumber, WithdrawTb.Text);
                MessageBox.Show("Amount Withdrawn Successfully");
            }
            else
            {
                MessageBox.Show("Out of balance");
            }
        }

        private void WITHDRAW_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            HOME hm = new HOME();
            hm.Show();
            this.Hide();
        }
    }
}
