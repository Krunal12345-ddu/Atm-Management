using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{

    public class Transaction:ITransaction
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\parek\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");



        public void withdrawamount(int Acc, string wdAmt)
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                Transaction1 transaction = new Transaction1();
                string query = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, @Type, @Amount, @TDate)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@Type", TrType);
                cmd.Parameters.AddWithValue("@Amount", wdAmt);
                cmd.Parameters.AddWithValue("@TDate", DateTime.Now);
                cmd.ExecuteNonQuery();

                // Update account balance
                int withdrawnAmount = int.Parse(wdAmt);
                string updateQuery = "UPDATE AccountTbl SET Balance = Balance - @WithdrawnAmount WHERE AccNum = @Acc";
                SqlCommand updateCmd = new SqlCommand(updateQuery, Con);
                updateCmd.Parameters.AddWithValue("@WithdrawnAmount", wdAmt);
                updateCmd.Parameters.AddWithValue("@Acc", Acc);
                updateCmd.ExecuteNonQuery();

                Con.Close();

            }
            catch (Exception ex) { }
            }

        public void depositamount(int Acc, string dpAmt)
        {
            string TrType = "Deposit";
            try
            {
                Con.Open();
                Transaction1 transaction = new Transaction1();
                string query = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, @Type, @Amount, @TDate)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@Type", TrType);
                cmd.Parameters.AddWithValue("@Amount", dpAmt);
                cmd.Parameters.AddWithValue("@TDate", DateTime.Now);
                cmd.ExecuteNonQuery();

                // Update account balance
                int withdrawnAmount = int.Parse(dpAmt);
                string updateQuery = "UPDATE AccountTbl SET Balance = Balance + @WithdrawnAmount WHERE AccNum = @Acc";
                SqlCommand updateCmd = new SqlCommand(updateQuery, Con);
                updateCmd.Parameters.AddWithValue("@WithdrawnAmount", dpAmt);
                updateCmd.Parameters.AddWithValue("@Acc", Acc);
                updateCmd.ExecuteNonQuery();

                Con.Close();

            }
            catch (Exception ex) { }
        }


        public DataSet GetMiniStatement(int accNum)
        {
            DataSet ds = new DataSet();
            try
            {
                Con.Open();

                string query = "SELECT * FROM TransactionTbl WHERE AccNum = @AccNum";
                SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
                adapter.SelectCommand.Parameters.AddWithValue("@AccNum", accNum);

                adapter.Fill(ds, "TransactionHistory");

                Con.Close();
            }
            catch (Exception ex)
            {
                // Handle exception or log it
            }

            return ds;
        }


        public void Fastcash(int Acc, int currency_val,int quantity)
        {
            string TrType = "FastCash";
            try
            {
                Con.Open();
                Transaction1 transaction = new Transaction1();
                string query = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, @Type, @Amount, @TDate)";
                SqlCommand cmd = new SqlCommand(query, Con);
                int wdAmt = currency_val * quantity;
                
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@Type", TrType);
                cmd.Parameters.AddWithValue("@Amount", wdAmt);
                cmd.Parameters.AddWithValue("@TDate", DateTime.Now);
                cmd.ExecuteNonQuery();

                // Update account balance
                int withdrawnAmount = int.Parse(wdAmt.ToString());
               
                string updateQuery = "UPDATE AccountTbl SET Balance = Balance - @WithdrawnAmount WHERE AccNum = @Acc";
                SqlCommand updateCmd = new SqlCommand(updateQuery, Con);
                updateCmd.Parameters.AddWithValue("@WithdrawnAmount", wdAmt);
                updateCmd.Parameters.AddWithValue("@Acc", Acc);
                updateCmd.ExecuteNonQuery();

                Con.Close();

            }
            catch (Exception ex) { }
        }




    }
}
