using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ATM1
{
    [ServiceContract]
    public interface ITransaction
    {
        [OperationContract]

        void withdrawamount(int Acc, string wdAmt);
        [OperationContract]
        void depositamount(int Acc, string dpAmt);
        [OperationContract]
        DataSet GetMiniStatement(int accNum);

        [OperationContract]
         void Fastcash(int Acc, int currency_val, int quantity);
    }
    [DataContract]

    public class Transaction1
    {
        private int TId;
        private int AccNum;
        private string Type;
        private int Amount;
        private DateTime TDate;


        [DataMember]
        public int TransactionId
        {
            get { return TId; }
            set { TId = value; }
        }
        [DataMember]
        public int AccountNumber
        {
            get { return AccNum; }
            set { AccNum = value; }
        }
        [DataMember]
        public string type
        {
            get { return Type; }
            set { Type = value; }
        }

        [DataMember]
        public int Amt
        {
            get { return Amount; }
            set { Amount = value; }
        }

        [DataMember]
        public DateTime TimeandDate
        {
            get { return TDate; }
            set { TDate = value; }
        }
    }
}