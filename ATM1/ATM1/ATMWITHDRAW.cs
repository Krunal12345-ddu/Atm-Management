using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ATM1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ATMWITHDRAW : IATMWITHDRAW
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\parek\OneDrive\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        public int get_balance(int Acc)
        {
            

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = "select Balance from AccountTbl where AccNum=@Acc";
            SqlParameter param = new SqlParameter("@Acc", Acc);
            cmd.Parameters.Add(param);
            Con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Account account = new Account();
            while (reader.Read())
            {
                account.bal = reader.GetInt32(0);
            }
            reader.Close();
            Con.Close();
            return account.bal;

        }


        public void InsertAccount(int accNum, string accName, string faName, DateTime dob, string phone, string address, string education, string occupation, string pin, int balance)
        {
            try
            {
                Con.Open();

                string query = "INSERT INTO AccountTbl (AccNum, Name, FaName, Dob, Phone, Address, Education, Occupation, PIN, Balance) " +
                               "VALUES (@AccNum, @AccName, @FaName, @DateOfBirth, @Phone, @Address, @Education, @Occupation, @Pin, @Balance)";
                
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", accNum);
                cmd.Parameters.AddWithValue("@AccName", accName);
                cmd.Parameters.AddWithValue("@faName", faName);
                cmd.Parameters.AddWithValue("@DateOfBirth", dob);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Education", education);
                cmd.Parameters.AddWithValue("@Occupation", occupation);
                cmd.Parameters.AddWithValue("@Pin", pin);
                cmd.Parameters.AddWithValue("@Balance", balance);

                cmd.ExecuteNonQuery();



                Con.Close();
            }
            catch { }
        }

        public void ChangePin(int Acc, int newPin)
        {
            try
            {
                Con.Open();

                string query = "UPDATE AccountTbl SET PIN = @NewPin WHERE AccNum = @AccNum";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@NewPin", newPin);
                cmd.Parameters.AddWithValue("@AccNum", Acc);

                cmd.ExecuteNonQuery();



                Con.Close();
            }
            catch (Exception ex)
            {

            }
        }


        public bool ValidateLogin(int accNum, int pin)
        {
            bool isValid = false;
            try
            {
                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM AccountTbl WHERE Accnum = @AccNum AND PIN = @Pin", Con);
                sda.SelectCommand.Parameters.AddWithValue("@AccNum", accNum);
                sda.SelectCommand.Parameters.AddWithValue("@Pin", pin);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    int count = Convert.ToInt32(dt.Rows[0][0]);
                    if (count == 1)
                    {
                        isValid = true;
                    }
                }

                Con.Close();
            }
            catch (Exception ex)
            {
              
            }

            return isValid;
        }
    }
}
