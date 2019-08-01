using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace team3.DAL
{
    public class TransferFundDAO
    {
        string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;


        public TransferFund getBalance(string WalletID)
        {

            //Get connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            SqlDataAdapter da;
            DataSet ds = new DataSet();
            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("Select BalanceAmt from eWallet where WalletID = @paraWalletID");

            da = new SqlDataAdapter(sqlCommand.ToString(), myConn);
            da.SelectCommand.Parameters.AddWithValue("paraWalletID", WalletID);

            da.Fill(ds, "eWallet");

            int rec_cnt = ds.Tables["eWallet"].Rows.Count;

            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables["eWallet"].Rows[0];
                TransferFund obj = new TransferFund();
                obj.BalanceAmt = Convert.ToDouble(row["BalanceAmt"]);
                return obj;

            }
            else
            {
                return null;
            }

        }
        public void ComputenewBalance1(double BalanceAmt, double Amt
            , string TransactionDte, string TransactionType, string WalletID, int newTransactionID)
        {
            BalanceAmt = BalanceAmt + Amt;
            newTransactionID = newTransactionID + 1;

            //update new balanceamount to database

            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            StringBuilder sqlStr = new StringBuilder();
            sqlStr.AppendLine("Update eWallet set BalanceAmt=@paraBalanceAmt where WalletID like @paraWalletID;");
            sqlStr.AppendLine("INSERT INTO Transactions (TransactionID,TransactionAmt,TransactionDte,TransactionType,WalletID)");
            sqlStr.AppendLine("Values(@paraTransactionID,@paraTransactionAmt,@paraTransactionDte,@paraTransactionType,@paraWalletID);");

            SqlConnection myConn = new SqlConnection(DBConnect);
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd = new SqlCommand(sqlStr.ToString(), myConn);
            /* using customer.DAO update , set BalanceAmt=BalanceAmt */

            sqlCmd.Parameters.AddWithValue("@paraBalanceAmt", BalanceAmt);
            sqlCmd.Parameters.AddWithValue("@paraTransactionAmt", Amt);
            sqlCmd.Parameters.AddWithValue("@paraTransactionDte", TransactionDte);
            sqlCmd.Parameters.AddWithValue("@paraTransactionType", TransactionType);
            sqlCmd.Parameters.AddWithValue("@paraWalletID", WalletID);
            sqlCmd.Parameters.AddWithValue("@paraTransactionID", newTransactionID);




            myConn.Open();
            sqlCmd.ExecuteNonQuery();
            myConn.Close();




        }
        public void ComputenewBalance2(double BalanceAmt, double Amt
            , string TransactionDte, string TransactionType, string WalletID, int newTransactionID)
        {
            BalanceAmt = BalanceAmt - Amt;
            newTransactionID = newTransactionID + 1;
            //update new balanceamount to database

            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            StringBuilder sqlStr = new StringBuilder();
            sqlStr.AppendLine("Update eWallet set BalanceAmt=@paraBalanceAmt where WalletID like @paraWalletID;");
            sqlStr.AppendLine("INSERT INTO Transactions (TransactionID,TransactionAmt,TransactionDte,TransactionType,WalletID)");
            sqlStr.AppendLine("Values(@paraTransactionID,@paraTransactionAmt,@paraTransactionDte,@paraTransactionType,@paraWalletID);");

            SqlConnection myConn = new SqlConnection(DBConnect);
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd = new SqlCommand(sqlStr.ToString(), myConn);
            /* using customer.DAO update , set BalanceAmt=BalanceAmt */

            sqlCmd.Parameters.AddWithValue("@paraBalanceAmt", BalanceAmt);
            sqlCmd.Parameters.AddWithValue("@paraTransactionAmt", Amt);
            sqlCmd.Parameters.AddWithValue("@paraTransactionDte", TransactionDte);
            sqlCmd.Parameters.AddWithValue("@paraTransactionType", TransactionType);
            sqlCmd.Parameters.AddWithValue("@paraWalletID", WalletID);
            sqlCmd.Parameters.AddWithValue("@paraTransactionID", newTransactionID);




            myConn.Open();
            sqlCmd.ExecuteNonQuery();
            myConn.Close();




        }
        public TransferFund getTransactionID(string WalletID)
        {

            //Get connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            SqlDataAdapter da;
            DataSet ds = new DataSet();
            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("Select max(TransactionID) from eWallet;");

            da = new SqlDataAdapter(sqlCommand.ToString(), myConn);


            da.Fill(ds, "eWallet");

            int rec_cnt = ds.Tables["eWallet"].Rows.Count;

            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables["eWallet"].Rows[0];
                TransferFund obj = new TransferFund();
                obj.BalanceAmt = Convert.ToDouble(row["TransactionID"]);
                return obj;

            }
            else
            {
                return null;
            }

        }
    }
}