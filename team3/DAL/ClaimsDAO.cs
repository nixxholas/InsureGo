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
    public class ClaimsDAO
    {
        string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        public string getName(string NRIC)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("select name from Customer Where NRIC = @paraNRIC");

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.SelectCommand.Parameters.AddWithValue("paraNRIC", NRIC);

            da.Fill(ds, "Customer");

            int rec_cnt = ds.Tables["Customer"].Rows.Count;

            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables["Customer"].Rows[0];
                var name = row["name"].ToString();
                return name;
            }

            return null;
        }
        public void InsertClaim(DateTime FiledDte, string Remarks, string ClaimStatus, string Location, DateTime IncidentTime,
                            string DisabilityType, string Deceasedname, string DeceasedNRIC, int PolicyNum)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.AppendLine("INSERT INTO Claim (FiledDte, Remarks, ClaimStatus, Location, IncidentDate, DisabilityType,");
            sqlStr.AppendLine("Deceasedname, DeceasedNRIC ,Policy_Num_FK)");
            sqlStr.AppendLine("Values(@paraFiledDte, @paraRemarks, @paraClaimStatus, @paraLocation, @paraIncidentDate, @paraDisabilityType,");
            sqlStr.AppendLine("@paraDeceasedname, @paraDeceasedNRIC ,@paraPolicy_Num_FK)");
       



            SqlConnection myConn = new SqlConnection(DBConnect);

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd = new SqlCommand(sqlStr.ToString(), myConn);

            // Step 3 : Add each parameterised query variable with value
            //          complete to add all parameterised queries
            sqlCmd.Parameters.AddWithValue("@paraFiledDte", FiledDte);
            sqlCmd.Parameters.AddWithValue("@paraRemarks", Remarks);
            sqlCmd.Parameters.AddWithValue("@paraClaimStatus", ClaimStatus);
            // Replace( @para, replace parameter)
            sqlCmd.Parameters.AddWithValue("@paraLocation", Location);
            sqlCmd.Parameters.AddWithValue("@paraIncidentDate", IncidentTime);
            sqlCmd.Parameters.AddWithValue("@paraDisabilityType", DisabilityType);
            sqlCmd.Parameters.AddWithValue("@paraDeceasedname", Deceasedname);
            sqlCmd.Parameters.AddWithValue("@paraDeceasedNRIC", DeceasedNRIC);
            sqlCmd.Parameters.AddWithValue("@paraPolicy_Num_FK", PolicyNum);
            // till here!


            myConn.Open();
            sqlCmd.ExecuteNonQuery();
            myConn.Close();

        }
    }
}