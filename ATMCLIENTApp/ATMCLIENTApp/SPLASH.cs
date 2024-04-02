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
    public partial class SPLASH : Form
    {
        public SPLASH()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int startpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 2;
            myProgress.Value = startpos;
            percentagelbl.Text = startpos + "%";
            if (myProgress.Value == 100)
            {
                myProgress.Value = 0;
                timer1.Stop();
                LOGIN log = new LOGIN();
                log.Show();
                this.Hide();

            }
        }
    }
}
