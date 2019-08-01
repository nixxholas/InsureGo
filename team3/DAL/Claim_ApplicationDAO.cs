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
    public class Claim_ApplicationDAO
    {
        string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        public List<Claim_Application> getAllClaimApplication()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("SELECT * FROM Claim c");
            sqlCommand.AppendLine("inner join policy p on p.policyNum = c.policy_num_fk");
            sqlCommand.AppendLine("WHERE ClaimStatus LIKE 'Pending%'");

            List<Claim_Application> claimList = new List<Claim_Application>();

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.Fill(ds, "Claim");

            int rec_cnt = ds.Tables["Claim"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i=0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["Claim"].Rows[i];
                    Claim_Application obj = new Claim_Application();
                    obj.ClaimID = row["ClaimID"].ToString();
                    obj.FiledDte = Convert.ToDateTime(row["FiledDte"]);
                    obj.Remarks = row["Remarks"].ToString();
                    obj.ClaimStatus = row["ClaimStatus"].ToString();
                    obj.Location = row["Location"].ToString();
                    obj.IncidentDate = Convert.ToDateTime(row["IncidentDate"]);
                    obj.DisabilityType = row["DisabilityType"].ToString();
                    obj.DeceasedName = row["DeceasedName"].ToString();
                    obj.DeceasedNRIC = row["DeceasedNRIC"].ToString();
                    obj.PolicyType = row["PolicyType"].ToString();

                    claimList.Add(obj);
                }
            }

            return claimList;
        }

        public List<Claim_Application> searchByClaimID(string ClaimID)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            //create adapter
            //write sql statements

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("SELECT * FROM Claim c");
            sqlCommand.AppendLine("inner join policy p on p.policyNum = c.policy_num_fk");
            sqlCommand.AppendLine("WHERE c.claimID LIKE @paraClaimID");

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            string va = "%" + ClaimID + "%";
            da.SelectCommand.Parameters.Add(new SqlParameter("paraClaimID", va));
            da.Fill(ds, "Claim");

            List<Claim_Application> claimList = new List<Claim_Application>();
            int rec_cnt = ds.Tables["Claim"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i = 0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["Claim"].Rows[i];
                    Claim_Application obj = new Claim_Application();
                    obj.ClaimID = row["ClaimID"].ToString();
                    //obj.ClaimAmt = Convert.ToDecimal(row["ClaimAmt"]);
                    obj.FiledDte = Convert.ToDateTime(row["FiledDte"]);
                    obj.Remarks = row["Remarks"].ToString();
                    obj.ClaimStatus = row["ClaimStatus"].ToString();
                    obj.Location = row["Location"].ToString();
                    obj.IncidentDate = Convert.ToDateTime(row["IncidentDate"]);
                    obj.DisabilityType = row["DisabilityType"].ToString();
                    obj.DeceasedName = row["DeceasedName"].ToString();
                    obj.DeceasedNRIC = row["DeceasedNRIC"].ToString();
                    obj.PolicyType = row["PolicyType"].ToString();

                    claimList.Add(obj);
                }
                return claimList;
            }

            else
            {
                return null;
            }
        }

        public List<Claim_Application> filterByClaimStatus(string ClaimStatus)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("SELECT * FROM Claim c");
            sqlCommand.AppendLine("inner join policy p on p.policyNum = c.policy_num_fk");
            sqlCommand.AppendLine("WHERE ClaimStatus = @paraClaimStatus");

            List<Claim_Application> claimList = new List<Claim_Application>();

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.SelectCommand.Parameters.AddWithValue("paraClaimStatus", ClaimStatus);
            da.Fill(ds, "Claim");

            int rec_cnt = ds.Tables["Claim"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i = 0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["Claim"].Rows[i];
                    Claim_Application obj = new Claim_Application();
                    obj.ClaimID = row["ClaimID"].ToString();
                    //obj.ClaimAmt = Convert.ToDecimal(row["ClaimAmt"]);
                    obj.FiledDte = Convert.ToDateTime(row["FiledDte"]);
                    obj.Remarks = row["Remarks"].ToString();
                    obj.ClaimStatus = row["ClaimStatus"].ToString();
                    obj.Location = row["Location"].ToString();
                    obj.IncidentDate = Convert.ToDateTime(row["IncidentDate"]);
                    obj.DisabilityType = row["DisabilityType"].ToString();
                    obj.DeceasedName = row["DeceasedName"].ToString();
                    obj.DeceasedNRIC = row["DeceasedNRIC"].ToString();
                    obj.PolicyType = row["PolicyType"].ToString();

                    claimList.Add(obj);
                }
            }

            return claimList;
        }

        public List<Claim_Application> filterByPolicyType(string policyType)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("SELECT * FROM Claim c");
            sqlCommand.AppendLine("inner join policy p on p.policyNum = c.policy_num_fk");
            sqlCommand.AppendLine("WHERE p.policytype = @paraPolicyType");

            List<Claim_Application> claimList = new List<Claim_Application>();

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.SelectCommand.Parameters.AddWithValue("paraPolicyType", policyType);
            da.Fill(ds, "Claim");

            int rec_cnt = ds.Tables["Claim"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i = 0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["Claim"].Rows[i];
                    Claim_Application obj = new Claim_Application();
                    obj.ClaimID = row["ClaimID"].ToString();
                    //obj.ClaimAmt = Convert.ToDecimal(row["ClaimAmt"]);
                    obj.FiledDte = Convert.ToDateTime(row["FiledDte"]);
                    obj.Remarks = row["Remarks"].ToString();
                    obj.ClaimStatus = row["ClaimStatus"].ToString();
                    obj.Location = row["Location"].ToString();
                    obj.IncidentDate = Convert.ToDateTime(row["IncidentDate"]);
                    obj.DisabilityType = row["DisabilityType"].ToString();
                    obj.DeceasedName = row["DeceasedName"].ToString();
                    obj.DeceasedNRIC = row["DeceasedNRIC"].ToString();
                    obj.PolicyType = row["PolicyType"].ToString();

                    claimList.Add(obj);
                }
            }

            return claimList;
        }

        public List<Claim_Application> sortApplicationByDate(bool sort)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();

            if (sort)
            {
                sqlCommand.AppendLine("SELECT * FROM Claim c");
                sqlCommand.AppendLine("inner join policy p on p.policyNum = c.policy_num_fk");
                sqlCommand.AppendLine("order by c.filedDte desc");
            }
            else
            {
                sqlCommand.AppendLine("SELECT * FROM Claim c");
                sqlCommand.AppendLine("inner join policy p on p.policyNum = c.policy_num_fk");
                sqlCommand.AppendLine("order by c.filedDte");
            }

            List<Claim_Application> claimList = new List<Claim_Application>();

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.Fill(ds, "Claim");

            int rec_cnt = ds.Tables["Claim"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i = 0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["Claim"].Rows[i];
                    Claim_Application obj = new Claim_Application();
                    obj.ClaimID = row["ClaimID"].ToString();
                    //obj.ClaimAmt = Convert.ToDecimal(row["ClaimAmt"]);
                    obj.FiledDte = Convert.ToDateTime(row["FiledDte"]);
                    obj.Remarks = row["Remarks"].ToString();
                    obj.ClaimStatus = row["ClaimStatus"].ToString();
                    obj.Location = row["Location"].ToString();
                    obj.IncidentDate = Convert.ToDateTime(row["IncidentDate"]);
                    obj.DisabilityType = row["DisabilityType"].ToString();
                    obj.DeceasedName = row["DeceasedName"].ToString();
                    obj.DeceasedNRIC = row["DeceasedNRIC"].ToString();
                    obj.PolicyType = row["PolicyType"].ToString();

                    claimList.Add(obj);
                }
            }

            return claimList;
        }

        public Claim_Application getClaimApplication(string ClaimID)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("Select * From Claim c");
            sqlCommand.AppendLine("Inner Join Policy p on p.PolicyNum = c.Policy_num_fk");
            sqlCommand.AppendLine("inner join risk_assesment ra on ra.claimID_fk = c.claimID");
            sqlCommand.AppendLine("Where c.ClaimID = @paraClaimID;");

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.SelectCommand.Parameters.AddWithValue("paraClaimID", ClaimID);

            da.Fill(ds, "Claim");

            int rec_cnt = ds.Tables["Claim"].Rows.Count;

            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables["Claim"].Rows[0];
                Claim_Application obj = new Claim_Application();

                obj.ClaimID = row["ClaimID"].ToString();
                obj.ClaimStatus = row["ClaimStatus"].ToString();
                obj.ClaimAmt = Convert.ToDecimal(row["ClaimAmt"]);
                obj.IncidentDate = Convert.ToDateTime(row["IncidentDate"]);
                obj.Location = row["Location"].ToString();
                obj.Remarks = row["Remarks"].ToString();
                obj.PolicyType = row["PolicyType"].ToString();
                obj.FiledDte = Convert.ToDateTime(row["FiledDte"]);
                obj.uwComment = row["Comments"].ToString();
                obj.PolicyNum = row["Policy_Num_FK"].ToString();

                if (row["PolicyType"].ToString() == "Life")
                {
                    obj.DeceasedName = row["Deceasedname"].ToString();
                    obj.DeceasedNRIC = row["DecreasedNRIC"].ToString();
                }

                else if (row["PolicyType"].ToString() == "Disability")
                {
                    obj.DisabilityType = row["DisabilityType"].ToString();
                }

                return obj;
            }

            else
            {
                return null;
            }
        }

        public void updateClaim(bool status, string ClaimID, string AdminComments, string PolicyNum, string StaffID)
        {
            StringBuilder sqlCommand = new StringBuilder();

            if (status)
            {
                sqlCommand.AppendLine("Update risk_assesment");
                sqlCommand.AppendLine("Set admincomments = @paraAdminComments");
                sqlCommand.AppendLine("Where ClaimID_FK = @paraClaimID;");

                sqlCommand.AppendLine("Update Policy");
                sqlCommand.AppendLine("Set MaturedDate = GETDATE()");
                sqlCommand.AppendLine("Where PolicyNum = @paraPolicyNum;");

                sqlCommand.AppendLine("Update Claim");
                sqlCommand.AppendLine("Set ClaimStatus = 'Approved', Approve_Staff_FK = @paraStaffID");
                sqlCommand.AppendLine("Where ClaimID = @paraClaimID;");

                SqlConnection myConn = new SqlConnection(DBConnect);

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd = new SqlCommand(sqlCommand.ToString(), myConn);

                sqlCmd.Parameters.AddWithValue("paraAdminComments", AdminComments);
                sqlCmd.Parameters.AddWithValue("paraClaimID", ClaimID);
                sqlCmd.Parameters.AddWithValue("paraPolicyNum", PolicyNum);
                sqlCmd.Parameters.AddWithValue("paraStaffID", StaffID);

                myConn.Open();
                sqlCmd.ExecuteNonQuery();
                myConn.Close();
            }
            else
            {
                sqlCommand.AppendLine("Update risk_assesment");
                sqlCommand.AppendLine("Set admincomments = @paraAdminComments");
                sqlCommand.AppendLine("Where ClaimID_FK = @paraClaimID;");

                sqlCommand.AppendLine("Update Claim");
                sqlCommand.AppendLine("Set ClaimStatus = 'Rejected', Approve_Staff_FK = @paraStaffID");
                sqlCommand.AppendLine("Where ClaimID = @paraClaimID;");

                SqlConnection myConn = new SqlConnection(DBConnect);

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd = new SqlCommand(sqlCommand.ToString(), myConn);

                sqlCmd.Parameters.AddWithValue("paraAdminComments", AdminComments);
                sqlCmd.Parameters.AddWithValue("paraClaimID", ClaimID);
                sqlCmd.Parameters.AddWithValue("paraStaffID", StaffID);

                myConn.Open();
                sqlCmd.ExecuteNonQuery();
                myConn.Close();
            }
        }

        public void updateClaimByUnderWriter(string ClaimID, string comments, decimal claimAmt, string staffID)
        {
            StringBuilder sqlCommand = new StringBuilder();

            sqlCommand.AppendLine("insert into Risk_Assesment(Comments, ClaimAmt, AssessStaff_FK, ClaimID_FK)");
            sqlCommand.AppendLine("values (@paraComments, @paraClaimAmt, @paraStaffID, @paraClaimID);");

            sqlCommand.AppendLine("update Claim");
            sqlCommand.AppendLine("set ClaimStatus = 'Pending Approval'");
            sqlCommand.AppendLine("where ClaimID = @paraClaimID;");

            SqlConnection myConn = new SqlConnection(DBConnect);

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd = new SqlCommand(sqlCommand.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("paraComments", comments);
            sqlCmd.Parameters.AddWithValue("paraClaimAmt", claimAmt);
            sqlCmd.Parameters.AddWithValue("paraStaffID", staffID);
            sqlCmd.Parameters.AddWithValue("paraClaimID", ClaimID);

            myConn.Open();
            sqlCmd.ExecuteNonQuery();
            myConn.Close();
        }

    }
}