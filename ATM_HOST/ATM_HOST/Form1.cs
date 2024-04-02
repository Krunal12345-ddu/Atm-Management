using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.ServiceModel.Description;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM1;

namespace ATM_HOST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ServiceHost sh = null;
        ServiceHost bh = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            

            try
            {
                Uri httpa = new Uri("http://localhost:8733/Design_Time_Addresses/Atmwith");
                sh = new ServiceHost(typeof(ATMWITHDRAW), httpa);
                WSHttpBinding httpb = new WSHttpBinding();
                ServiceMetadataBehavior mbehave = new ServiceMetadataBehavior();
                sh.Description.Behaviors.Add(mbehave);
                sh.AddServiceEndpoint(typeof(IMetadataExchange),
                MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
                sh.AddServiceEndpoint(typeof(IATMWITHDRAW), httpb, httpa);
                sh.Open();

                Uri httpd = new Uri("http://localhost:8733/Design_Time_Addresses/transac");
                bh = new ServiceHost(typeof(Transaction), httpd);
                WSHttpBinding httpc = new WSHttpBinding();
                ServiceMetadataBehavior nbehave = new ServiceMetadataBehavior();
                bh.Description.Behaviors.Add(nbehave);
                bh.AddServiceEndpoint(typeof(IMetadataExchange),
                MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
                bh.AddServiceEndpoint(typeof(ITransaction), httpc, httpd);
                bh.Open();


                label1.Text = "Server Running";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
                Console.WriteLine(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}




        
     
