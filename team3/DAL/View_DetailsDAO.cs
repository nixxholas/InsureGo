using System;
using System.Web;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Text;

namespace team3.DAL
{
    public class View_DetailsDAO
    {
        public View_Details getDetails(string AppID)
        {
            string DBConnect;
            DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("Select RefID, Comments, PRate from Risk_Assesment ra");
            sqlCommand.AppendLine("inner join New_Application na on na.AppID = ra.New_Application_FK");
            sqlCommand.AppendLine("where na.AppID = @paraAppID");

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.SelectCommand.Parameters.AddWithValue("paraAppID", AppID);

            da.Fill(ds, "Risk_Assesment");

            int rec_cnt = ds.Tables["Risk_Assesment"].Rows.Count;

            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables["Risk_Assesment"].Rows[0];
                View_Details obj = new View_Details();
                obj.comments = row["Comments"].ToString();
                obj.pRate = Convert.ToDouble(row["PRate"]);
                obj.refID = row["RefID"].ToString();
                return obj;
            }
            else
            {
                return null;
            }

        }

        public void updateStatus(bool status, string AppID, string NRIC, string StaffID, string Type, decimal PRate, string adminComment)
        {
            string DBConnect;
            DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            StringBuilder sqlCommand = new StringBuilder();

            if (status)
            {
                
                sqlCommand.AppendLine("update New_Application");
                sqlCommand.AppendLine("set AppStatus = 'Approved'");
                sqlCommand.AppendLine("where AppID = @paraAppID;");

                sqlCommand.AppendLine("UPDATE Risk_Assesment");
                sqlCommand.AppendLine("SET AdminComments = @paraAdminComment");
                sqlCommand.AppendLine("WHERE New_Application_FK = @paraAppID;");

                sqlCommand.AppendLine("insert into Policy(PolicyType, StartDate, MaturedDate, PremiumAmt, ApproveStaff_FK, Customer_NRIC_FK)");
                sqlCommand.AppendLine("values (@paraType, GetDate() + 15, GetDate() + 380,@paraPRate, @paraStaffID, @paraNRIC)");

                SqlConnection myConn = new SqlConnection(DBConnect);

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd = new SqlCommand(sqlCommand.ToString(), myConn);

                sqlCmd.Parameters.AddWithValue("paraAppID", AppID);
                sqlCmd.Parameters.AddWithValue("paraType", Type);
                sqlCmd.Parameters.AddWithValue("paraPRate", PRate);
                sqlCmd.Parameters.AddWithValue("paraStaffID", StaffID);
                sqlCmd.Parameters.AddWithValue("paraNRIC", NRIC);
                sqlCmd.Parameters.AddWithValue("paraAdminComment", adminComment);

                myConn.Open();
                sqlCmd.ExecuteNonQuery();
                myConn.Close();

            }
            else
            {
                sqlCommand.AppendLine("update New_Application");
                sqlCommand.AppendLine("set AppStatus = 'Rejected'");
                sqlCommand.AppendLine("where AppID = @paraAppID;");

                sqlCommand.AppendLine("UPDATE Risk_Assesment");
                sqlCommand.AppendLine("SET AdminComments = @paraAdminComment");
                sqlCommand.AppendLine("WHERE New_Application_FK = @paraAppID;");

                SqlConnection myConn = new SqlConnection(DBConnect);

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd = new SqlCommand(sqlCommand.ToString(), myConn);

                sqlCmd.Parameters.AddWithValue("paraAppID", AppID);
                sqlCmd.Parameters.AddWithValue("paraAdminComment", adminComment);

                myConn.Open();
                sqlCmd.ExecuteNonQuery();
                myConn.Close();
            }

            
        }
    }
}