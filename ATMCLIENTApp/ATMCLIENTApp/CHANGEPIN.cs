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
    public partial class CHANGEPIN : Form
    {
        public CHANGEPIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ATMCLIENTApp.ATM1.ATMWITHDRAWClient proxy = new ATMCLIENTApp.ATM1.ATMWITHDRAWClient("WSHttpBinding_IATMWITHDRAW");
            proxy.ChangePin(Class1.AccountNumber,int.Parse(Pin2Tb.Text));
            MessageBox.Show("Pin changed successfully");
            
        }

        private void CHANGEPIN_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            HOME hm = new HOME();
            hm.Show();
            this.Show();
        }
    }
}
