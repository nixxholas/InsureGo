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
    public class CustomerDAO
    {
        string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        public void InsertUser(string NRIC, string Gender, string Name, string EmailAddress, string Password, string RAddress,
                            string RPostCode, string PNo, string HNo, string OAddress, string OPostCode,
                            string ONo, string Bank, DateTime DateOfBirth, string AcNo, double BalanceAmt)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.AppendLine("INSERT INTO eWallet (WalletID,BalanceAmt,BankActNum)");
            sqlStr.AppendLine("Values(@paraWalletID,@paraBalanceAmt,@paraBankActNum);");
            sqlStr.AppendLine("INSERT INTO Customer (NRIC,Password,Email,Gender,ContactNo,HomeNo,");
            sqlStr.AppendLine("Name,Address,PostalCode,BankName,AccountNo,DOB,OAddress,OPostalCode, OContact, WalletID_FK)");
            sqlStr.AppendLine("Values(@paraNRIC,@paraPassword,@paraEmail,@paraGender,@paraContactNo,@paraHomeContact,");
            sqlStr.AppendLine("@paraName,@paraAddress,@paraPostalCode,@paraBankName,@paraAccountNo,@paraDOB,");
            sqlStr.AppendLine("@paraOAddress,@paraOPostalCode, @paraOcontact, @paraWalletID);");



            SqlConnection myConn = new SqlConnection(DBConnect);

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd = new SqlCommand(sqlStr.ToString(), myConn);

            // Step 3 : Add each parameterised query variable with value
            //          complete to add all parameterised queries
            sqlCmd.Parameters.AddWithValue("@paraNRIC", NRIC);
            sqlCmd.Parameters.AddWithValue("@paraPassword", Password);
            sqlCmd.Parameters.AddWithValue("@paraEmail", EmailAddress);
            sqlCmd.Parameters.AddWithValue("@paraGender", Gender);
            sqlCmd.Parameters.AddWithValue("@paraDOB", DateOfBirth);
            sqlCmd.Parameters.AddWithValue("@paraContactNo", PNo);
            sqlCmd.Parameters.AddWithValue("@paraHomeContact", HNo);
            sqlCmd.Parameters.AddWithValue("@paraOaddress", OAddress);
            sqlCmd.Parameters.AddWithValue("@paraOPostalCode", OPostCode);
            sqlCmd.Parameters.AddWithValue("@paraOcontact", ONo);
            sqlCmd.Parameters.AddWithValue("@paraBankName", Bank);
            sqlCmd.Parameters.AddWithValue("@paraAccountNo", AcNo);
            sqlCmd.Parameters.AddWithValue("@paraName", Name);
            sqlCmd.Parameters.AddWithValue("@paraAddress", RAddress);
            sqlCmd.Parameters.AddWithValue("@paraPostalCode", RPostCode);
            sqlCmd.Parameters.AddWithValue("@paraBalanceAmt", BalanceAmt);
            sqlCmd.Parameters.AddWithValue("@paraWalletID", NRIC);
            sqlCmd.Parameters.AddWithValue("@paraBankActNum", AcNo);


            myConn.Open();
            sqlCmd.ExecuteNonQuery();
            myConn.Close();

        }
        public int ValidateSignIn(string UserName, string Password)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);
            StringBuilder sqlStr = new StringBuilder();

            /*  sqlStr.AppendLine("Select * from Customer");
              sqlStr.AppendLine("where NRIC=@paraNRIC and Password =@paraPassword ;");

              SqlCommand sqlCmd = new SqlCommand();
              sqlCmd = new SqlCommand(sqlStr.ToString(), myConn);



              sqlCmd.Parameters.AddWithValue("@paraNRIC", UserName);
              sqlCmd.Parameters.AddWithValue("@paraPassword", Password);
              myConn.Open();

              var result= sqlCmd.ExecuteNonQuery();
              myConn.Close();
              return result;

             */


            SqlDataAdapter da;
            DataSet ds = new DataSet();
            StringBuilder sqlCommand = new StringBuilder();

            sqlCommand.AppendLine("Select NRIC from Customer");
            sqlCommand.AppendLine("where NRIC=@paraNRIC and Password =@paraPassword;");

            da = new SqlDataAdapter(sqlCommand.ToString(), myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraNRIC", UserName);
            da.SelectCommand.Parameters.AddWithValue("@paraPassword", Password);

            da.Fill(ds, "Customer");
            var result = ds.Tables["Customer"].Rows.Count;
            return result;


        }
        public Customer FindName(string Session)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            SqlDataAdapter da;
            DataSet ds = new DataSet();
            StringBuilder sqlCommand = new StringBuilder();

            sqlCommand.AppendLine("Select Name from Customer where NRIC = @paraSession;");

            da = new SqlDataAdapter(sqlCommand.ToString(), myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraSession", Session);

            da.Fill(ds, "Customer");

            int rec_cnt = ds.Tables["Customer"].Rows.Count;

            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables["Customer"].Rows[0];
                Customer Cust = new Customer();
                Cust.Name = Convert.ToString(row["Name"]);
                return Cust;
            }
            else
            {
                return null;
            }
        }

    }
    
}