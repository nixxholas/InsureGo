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
    public class NotificationsDAO
    {
        string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        public List<string> getNotification(string NRIC)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("select policynum from policy where Customer_NRIC_FK = @paraNRIC and (convert(datetime, paymentDate) - getDate() <=7)");
            List<string> polnum = new List<string>();

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.SelectCommand.Parameters.AddWithValue("paraNRIC", NRIC);
            da.Fill(ds, "Policy");

            int rec_cnt = ds.Tables["Policy"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i = 0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["Policy"].Rows[i];
                    polnum.Add(row["PolicyNum"].ToString());
                }
            }

            return polnum;

        }

        public void checkIfNotificationExists(string PolNum, string NRIC)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("Select * from notifications");
            sqlCommand.AppendLine("where policynum = @paraPolNum");

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.SelectCommand.Parameters.AddWithValue("paraPolNum", PolNum);
            da.Fill(ds, "Notifications");

            int rec_cnt = ds.Tables["Notifications"].Rows.Count;

            if (rec_cnt == 0)
            {
                StringBuilder sqlStr = new StringBuilder();

                sqlStr.AppendLine("insert into notifications(Date, NRIC, PolicyNum)");
                sqlStr.AppendLine("values GETDATE(), @paraNRIC, @paraPolNum");

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd = new SqlCommand(sqlStr.ToString(), myconn);

                sqlCmd.Parameters.AddWithValue("paraNRIC", NRIC);
                sqlCmd.Parameters.AddWithValue("paraPolNum", PolNum);

                myconn.Open();
                sqlCmd.ExecuteNonQuery();
                myconn.Close();
            }
        }

        public List<Notifications> getNotificationToDisplay(string NRIC)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("Select * from notifications");
            sqlCommand.AppendLine("where NRIC = @paraNRIC");

            List<Notifications> notificationList = new List<Notifications>();

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.SelectCommand.Parameters.AddWithValue("paraNRIC", NRIC);
            da.Fill(ds, "Notifications");

            int rec_cnt = ds.Tables["Policy"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i = 0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["Policy"].Rows[i];
                    Notifications obj = new Notifications();
                    obj.Message = row["Message"].ToString();
                    obj.date = Convert.ToDateTime(row["Date"]);
                    notificationList.Add(obj);
                }
                return notificationList;
            }
            else
            {
                return null;
            }

        }


    }
}