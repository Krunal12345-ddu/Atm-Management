using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;

namespace ATM1
{

    [ServiceContract]
    public interface IATMWITHDRAW
    {
        [OperationContract]
        int get_balance(int AccNum);
        [OperationContract]
        void ChangePin(int Acc, int newPin);

        [OperationContract]
        void InsertAccount(int accNum, string accName, string faName, DateTime dob, string phone, string address, string education, string occupation, string pin, int balance);

        [OperationContract]

        bool ValidateLogin(int accNum, int pin);
    }

    [DataContract]

    public class Account {
        private int AccNum;
        private string Name;
        private string FaName;
        private DateTime Dob;
        private int Phone;
        private string Address;
        private string Education;
        private string Occupation;
        private int PIN;
        private int Balance;


        [DataMember]
        public int AccountNumber
        {
            get { return AccNum; }
            set { AccNum = value; }
        }
        [DataMember]
        public string FirstName
        {
            get { return Name; }
            set { Name = value; }
        }
        [DataMember]
        public string lastName
        {
            get { return FaName; }
            set { FaName = value; }
        }

        [DataMember]
        public DateTime Dateofbirth {
            get { return Dob; } 
            set { Dob = value; }
       }
        [DataMember]
        public int phoneno {
            get { return Phone; }
            set { Phone = value; }

        }

        [DataMember]
        public string address { 
            get { return Address; }
            set { Address = value; }
        
        }

        [DataMember]

        public string Educ
        {
            get { return Education; }
            set { Education = value; }
        }

        [DataMember]
        public string Occup
        {
            get { return Occupation; }
            set { Occupation = value; }
        }

        [DataMember]
        public int pin
        {
            get { return PIN; }
            set { PIN = value; }
        }

        [DataMember]
        public int bal
        {
            get { return Balance; }
            set { Balance = value; }
        }

    }



}
