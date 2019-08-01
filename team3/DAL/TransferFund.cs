using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace team3.DAL
{
    public class TransferFund
    {
        public TransferFund()
        {

        }
        public double BalanceAmt { get; set; }
        public string TransactionID { get; set; }
        public double TransactionAmt { get; set; }
        public string TransactionDte { get; set; }
        public string TransactionType { get; set; }
        public string WalletID { get; set; }
        public string BankActNum { get; set; }
    }
}