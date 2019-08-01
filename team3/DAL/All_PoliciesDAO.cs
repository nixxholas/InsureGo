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
    public class All_PoliciesDAO
    {
        string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        public List<All_Policies> getAllPolicies()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("Select * from Policy");

            List<All_Policies> polList = new List<All_Policies>();

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.Fill(ds, "Policy");

            int rec_cnt = ds.Tables["Policy"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i = 0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["Policy"].Rows[i];
                    All_Policies obj = new All_Policies();

                    obj.CustomerNRIC = row["Customer_NRIC_FK"].ToString();
                    obj.MaturedDate = Convert.ToDateTime(row["MaturedDate"]);
                    obj.PolicyNum = row["PolicyNum"].ToString();
                    obj.PolicyType = row["PolicyType"].ToString();
                    obj.PremiumAmt = Convert.ToDecimal(row["PremiumAmt"]);
                    obj.StartDate = Convert.ToDateTime(row["StartDate"]);
                    obj.ApproveStaff = row["ApproveStaff_FK"].ToString();

                    polList.Add(obj);
                }
            }

            return polList;
        }

        public List<All_Policies> getActivePolicies()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("Select * from Policy");
            sqlCommand.AppendLine("Where MaturedDate > GETDATE();");

            List<All_Policies> polList = new List<All_Policies>();

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.Fill(ds, "Policy");

            int rec_cnt = ds.Tables["Policy"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i = 0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["Policy"].Rows[i];
                    All_Policies obj = new All_Policies();

                    obj.CustomerNRIC = row["Customer_NRIC_FK"].ToString();
                    obj.MaturedDate = Convert.ToDateTime(row["MaturedDate"]);
                    obj.PolicyNum = row["PolicyNum"].ToString();
                    obj.PolicyType = row["PolicyType"].ToString();
                    obj.PremiumAmt = Convert.ToDecimal(row["PremiumAmt"]);
                    obj.StartDate = Convert.ToDateTime(row["StartDate"]);
                    obj.ApproveStaff = row["ApproveStaff_FK"].ToString();

                    polList.Add(obj);
                }
            }

            return polList;
        }

        public List<All_Policies> getExpiredPolicies()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("Select * from Policy");
            sqlCommand.AppendLine("Where MaturedDate <= GETDATE();");

            List<All_Policies> polList = new List<All_Policies>();

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.Fill(ds, "Policy");

            int rec_cnt = ds.Tables["Policy"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i = 0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["Policy"].Rows[i];
                    All_Policies obj = new All_Policies();

                    obj.CustomerNRIC = row["Customer_NRIC_FK"].ToString();
                    obj.MaturedDate = Convert.ToDateTime(row["MaturedDate"]);
                    obj.PolicyNum = row["PolicyNum"].ToString();
                    obj.PolicyType = row["PolicyType"].ToString();
                    obj.PremiumAmt = Convert.ToDecimal(row["PremiumAmt"]);
                    obj.StartDate = Convert.ToDateTime(row["StartDate"]);
                    obj.ApproveStaff = row["ApproveStaff_FK"].ToString();

                    polList.Add(obj);
                }
            }

            return polList;
        }

        public List<All_Policies> searchByPolicyNum(string PolicyNum)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("Select * from Policy");
            sqlCommand.AppendLine("Where PolicyNum LIKE @paraPolicyNum");

            List<All_Policies> polList = new List<All_Policies>();

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            string va = "%" + PolicyNum + "%";
            da.SelectCommand.Parameters.Add(new SqlParameter("paraPolicyNum", va));
            da.Fill(ds, "Policy");

            int rec_cnt = ds.Tables["Policy"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i = 0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["Policy"].Rows[i];
                    All_Policies obj = new All_Policies();

                    obj.CustomerNRIC = row["Customer_NRIC_FK"].ToString();
                    obj.MaturedDate = Convert.ToDateTime(row["MaturedDate"]);
                    obj.PolicyNum = row["PolicyNum"].ToString();
                    obj.PolicyType = row["PolicyType"].ToString();
                    obj.PremiumAmt = Convert.ToDecimal(row["PremiumAmt"]);
                    obj.StartDate = Convert.ToDateTime(row["StartDate"]);
                    obj.ApproveStaff = row["ApproveStaff_FK"].ToString();

                    polList.Add(obj);
                }
            }

            return polList;
        }

        public List<All_Policies> filterByDate(bool sort)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();

            if (sort)
            {
                sqlCommand.AppendLine("Select * from Policy");
                sqlCommand.AppendLine("ORDER BY StartDate desc;");
            }
            else
            {
                sqlCommand.AppendLine("Select * from Policy");
                sqlCommand.AppendLine("ORDER BY StartDate;");
            }

            List<All_Policies> polList = new List<All_Policies>();

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.Fill(ds, "Policy");

            int rec_cnt = ds.Tables["Policy"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i = 0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["Policy"].Rows[i];
                    All_Policies obj = new All_Policies();

                    obj.CustomerNRIC = row["Customer_NRIC_FK"].ToString();
                    obj.MaturedDate = Convert.ToDateTime(row["MaturedDate"]);
                    obj.PolicyNum = row["PolicyNum"].ToString();
                    obj.PolicyType = row["PolicyType"].ToString();
                    obj.PremiumAmt = Convert.ToDecimal(row["PremiumAmt"]);
                    obj.StartDate = Convert.ToDateTime(row["StartDate"]);
                    obj.ApproveStaff = row["ApproveStaff_FK"].ToString();

                    polList.Add(obj);
                }
            }

            return polList;

        }

        public List<All_Policies> searchByNRIC(string NRIC)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("Select * from Policy");
            sqlCommand.AppendLine("Where Customer_NRIC_FK LIKE @paraNRIC");

            List<All_Policies> polList = new List<All_Policies>();

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            string va = "%" + NRIC + "%";
            da.SelectCommand.Parameters.Add(new SqlParameter("paraNRIC", va));
            da.Fill(ds, "Policy");

            int rec_cnt = ds.Tables["Policy"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i = 0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["Policy"].Rows[i];
                    All_Policies obj = new All_Policies();

                    obj.CustomerNRIC = row["Customer_NRIC_FK"].ToString();
                    obj.MaturedDate = Convert.ToDateTime(row["MaturedDate"]);
                    obj.PolicyNum = row["PolicyNum"].ToString();
                    obj.PolicyType = row["PolicyType"].ToString();
                    obj.PremiumAmt = Convert.ToDecimal(row["PremiumAmt"]);
                    obj.StartDate = Convert.ToDateTime(row["StartDate"]);
                    obj.ApproveStaff = row["ApproveStaff_FK"].ToString();

                    polList.Add(obj);
                }
            }

            return polList;
        }

        public All_Policies getPolicyDetails(string PolicyNum)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();

            sqlCommand.AppendLine("select * from Policy p");
            sqlCommand.AppendLine("inner join risk_assesment ra on ra.new_Application_FK = p.PolicyNum");
            sqlCommand.AppendLine("where p.policyNum = @paraPolicyNum");

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.SelectCommand.Parameters.AddWithValue("paraPolicyNum", PolicyNum);
            da.Fill(ds, "Policy");

            int rec_cnt = ds.Tables["Policy"].Rows.Count;

            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables["Policy"].Rows[0];
                All_Policies obj = new All_Policies();

                obj.PolicyNum = row["PolicyNum"].ToString();
                obj.PolicyType = row["PolicyType"].ToString();
                obj.StartDate = Convert.ToDateTime(row["StartDate"]);
                obj.MaturedDate = Convert.ToDateTime(row["MaturedDate"]);
                obj.PremiumAmt = Convert.ToDecimal(row["PremiumAmt"]);
                obj.CustomerNRIC = row["Customer_NRIC_FK"].ToString();
                obj.uwComments = row["Comments"].ToString();
                obj.adminComments = row["AdminComments"].ToString();

                return obj;
            }

            else
            {
                return null;
            }
        }

        public void updatePolicyPeriod(int period, string PolicyNum)
        {
            StringBuilder sqlStr = new StringBuilder();

            sqlStr.AppendLine("update Policy");
            sqlStr.AppendLine("set MaturedDate = (select DATEADD(year, @paraPeriod, MaturedDate) as MaturedDate from Policy where policynum = @paraPolicyNum)");
            sqlStr.AppendLine("Where PolicyNum = @paraPolicyNum;");

            SqlConnection myConn = new SqlConnection(DBConnect);

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd = new SqlCommand(sqlStr.ToString(), myConn);
            sqlCmd.Parameters.AddWithValue("paraPeriod", period);
            sqlCmd.Parameters.AddWithValue("paraPolicyNum", PolicyNum);

            myConn.Open();
            sqlCmd.ExecuteNonQuery();
            myConn.Close();
        }
    }
}