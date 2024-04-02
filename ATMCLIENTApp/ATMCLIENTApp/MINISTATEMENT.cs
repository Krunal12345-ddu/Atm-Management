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
    public partial class MINISTATEMENT : Form
    {
        public MINISTATEMENT()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            HOME hm = new HOME();
            hm.Show();
            this.Show();
        }

        private void MINISTATEMENT_Load(object sender, EventArgs e)
        {
            ATMCLIENTApp.Transaction.TransactionClient proxy = proxy = new ATMCLIENTApp.Transaction.TransactionClient("WSHttpBinding_ITransaction");
            DataSet miniStatementDataSet = proxy.GetMiniStatement(Class1.AccountNumber);


            statementdataview.DataSource = miniStatementDataSet.Tables[0];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
