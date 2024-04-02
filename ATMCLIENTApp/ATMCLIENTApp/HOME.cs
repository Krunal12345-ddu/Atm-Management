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
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            DEPOSIT deposit =new DEPOSIT();
            deposit.Show();
            this.Hide();
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            WITHDRAW withdraw = new WITHDRAW(); 
            withdraw.Show();
            this.Hide();

        }

        private void ChangePinTb_Click(object sender, EventArgs e)
        {
            CHANGEPIN cb =new CHANGEPIN();
            cb.Show();
            this.Hide();
        }

        private void BalanceTb_Click(object sender, EventArgs e)
        {
            BALANCE bl =new BALANCE();
            bl.Show();
            this.Hide();
        }

        private void MiniStatementTb_Click(object sender, EventArgs e)
        {
            MINISTATEMENT ms = new MINISTATEMENT();
            ms.Show();
            this.Hide();
        }

        private void HOME_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FastCash fc =new FastCash();
            fc.Show();
            this.Hide();

        }
    }
}
