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
    public partial class ACCOUNT : Form
    {
        public ACCOUNT()
        {
            InitializeComponent();
        }

        private void ACCOUNT_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ATMCLIENTApp.ATM1.ATMWITHDRAWClient proxy = new ATMCLIENTApp.ATM1.ATMWITHDRAWClient("WSHttpBinding_IATMWITHDRAW");
            
            proxy.InsertAccount(int.Parse(AccNumTb.Text),AccNameTb.Text,FanameTb.Text,dobdate.Value,PhoneTb.Text,AddressTb.Text,EducationTb.Text,occupationtb.Text,PinTb.Text,0);
            proxy.Close();

            LOGIN log = new LOGIN();
            log.Show();
            this.Hide();

        }

        private void PhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            LOGIN log = new LOGIN();
            log.Show();
            this.Show();
        }
    }
}
