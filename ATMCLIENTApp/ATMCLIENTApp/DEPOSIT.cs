using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMCLIENTApp
{
    public partial class DEPOSIT : Form
    {
        public DEPOSIT()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ATMCLIENTApp.Transaction.TransactionClient proxy = proxy = new ATMCLIENTApp.Transaction.TransactionClient("WSHttpBinding_ITransaction");
            proxy.depositamount(Class1.AccountNumber, DepositTb.Text);
            MessageBox.Show("Amount Deposited Successfully");
            

        }

        private void label7_Click(object sender, EventArgs e)
        {
            HOME hm = new HOME();
            hm.Show();
            this.Hide();
        }

        private void DEPOSIT_Load(object sender, EventArgs e)
        {

        }
    }
}
