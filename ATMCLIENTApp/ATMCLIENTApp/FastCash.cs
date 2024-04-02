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
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }

        private void FastCash_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ATMCLIENTApp.ATM1.ATMWITHDRAWClient proxy = new ATMCLIENTApp.ATM1.ATMWITHDRAWClient("WSHttpBinding_IATMWITHDRAW");

                // Retrieving the balance
                int balance = proxy.get_balance(Class1.AccountNumber);

                int totalAmt = 0;

                // Loop through the checked items in the CheckedListBox to calculate total amount
                foreach (var item in AmtlistBox.CheckedItems)

                {
                    
                    // If the CheckedListBox is bound to a collection of custom objects, you may need to cast 'item' to access its properties
                    // For example: var customObject = (YourCustomObjectType)item;

                    // Assuming the CheckedListBox is bound to simple strings, you can directly use 'item' as string
                    totalAmt += int.Parse(item.ToString());
                  
                }

                totalAmt *= int.Parse(QtTb.Text); // Assuming QtTb.Text holds the quantity
                //MessageBox.Show(totalAmt.ToString());
                
                if (balance > totalAmt)
                {

                    // Creating a proxy to the Transaction service
                    ATMCLIENTApp.Transaction.TransactionClient proxy1 = new ATMCLIENTApp.Transaction.TransactionClient("WSHttpBinding_ITransaction");

                    // Calling the Fastcash method of the Transaction service
                    proxy1.Fastcash(Class1.AccountNumber, totalAmt, 1); // Assuming quantity is always 1 for each selected item
                    MessageBox.Show("Amount withdrawal successful");
                }
                else
                {
                    MessageBox.Show("Out of Balance");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            HOME hm= new HOME();
            hm.Show();
            this.Hide();
        }
    }
}
