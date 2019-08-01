using System;
using System.Web;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Text;


namespace team3.DAL
{
    public class New_ApplicationDAO
    {

        public List<New_Application> getAllNewApplication()
        {
            // get connection string from web.config
            string DBConnect;
            DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            SqlDataAdapter da;
            DataSet ds = new DataSet();

            //create adapter
            //write sql statements

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("SELECT * FROM New_Application");
            sqlCommand.AppendLine("WHERE AppStatus LIKE 'Pending%'");

            //create list to store objects
            List<New_Application> appList = new List<New_Application>();

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.Fill(ds, "New_Application");

            int rec_cnt = ds.Tables["New_Application"].Rows.Count;
            
            if (rec_cnt > 0)
            {
                for (int i=0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["New_Application"].Rows[i];
                    New_Application obj = new New_Application();
                    obj.appID = row["AppID"].ToString();
                    obj.filedDte = Convert.ToDateTime(row["FiledDte"]);
                    obj.status = row["AppStatus"].ToString();
                    obj.type = row["InsType"].ToString();
                    obj.custNric = row["Cust_NRIC_FK"].ToString();
                    obj.assStaff = row["Assess_Staff_FK"].ToString();
                    

                    appList.Add(obj);
                }
            }

            return appList;

        }

        public List<New_Application> searchByAppNo(string appID)
        {
            string DBConnect;
            DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            SqlDataAdapter da;
            DataSet ds = new DataSet();

            //create adapter
            //write sql statements

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("SELECT * FROM New_Application");
            sqlCommand.AppendLine("WHERE AppID LIKE @paraAppID");

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            string va = "%" + appID + "%";
            da.SelectCommand.Parameters.Add(new SqlParameter("paraAppID", va));
            da.Fill(ds, "New_Application");

            List<New_Application> appList = new List<New_Application>();
            int rec_cnt = ds.Tables["New_Application"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i = 0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["New_Application"].Rows[i];
                    New_Application obj = new New_Application();
                    obj.appID = row["AppID"].ToString();
                    obj.filedDte = Convert.ToDateTime(row["FiledDte"]);
                    obj.status = row["AppStatus"].ToString();
                    obj.type = row["InsType"].ToString();
                    obj.custNric = row["Cust_NRIC_FK"].ToString();
                    obj.assStaff = row["Assess_Staff_FK"].ToString();
                    appList.Add(obj);
                }
                return appList;
            }
            else
            {
                return null;
            }

        }

        public New_Application getApplication(string appID)
        {
            string DBConnect;
            DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            SqlDataAdapter da;
            DataSet ds = new DataSet();

            //create adapter
            //write sql statements

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("SELECT * FROM New_Application");
            sqlCommand.AppendLine("WHERE AppID = @paraAppID");

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.SelectCommand.Parameters.AddWithValue("paraAppID", appID);

            da.Fill(ds, "New_Application");

            int rec_cnt = ds.Tables["New_Application"].Rows.Count;

            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables["New_Application"].Rows[0];
                New_Application obj = new New_Application();
                obj.appID = row["AppID"].ToString();
                obj.custNric = row["Cust_Nric_FK"].ToString();
                obj.filedDte = Convert.ToDateTime(row["FiledDte"]);
                obj.status = row["AppStatus"].ToString();
                obj.type = row["InsType"].ToString();
                obj.assStaff = row["Assess_Staff_FK"].ToString();
                return obj;
            }
            else
            {
                return null;
            }
        }

        public List<New_Application> getApplicationByType(string type)
        {
            string DBConnect;
            DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            SqlDataAdapter da;
            DataSet ds = new DataSet();

            //create adapter
            //write sql statements

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("SELECT * FROM New_Application");
            sqlCommand.AppendLine("WHERE InsType = @paratype and AppStatus LIKE 'Pending%'");

            //create list to store objects
            List<New_Application> appList = new List<New_Application>();

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.SelectCommand.Parameters.AddWithValue("paratype", type);
            da.Fill(ds, "New_Application");

            int rec_cnt = ds.Tables["New_Application"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i = 0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["New_Application"].Rows[i];
                    New_Application obj = new New_Application();
                    obj.appID = row["AppID"].ToString();
                    obj.filedDte = Convert.ToDateTime(row["FiledDte"]);
                    obj.status = row["AppStatus"].ToString();
                    obj.type = row["InsType"].ToString();
                    obj.custNric = row["Cust_NRIC_FK"].ToString();
                    obj.assStaff = row["Assess_Staff_FK"].ToString();


                    appList.Add(obj);
                }
            }

            return appList;

        }

        public List<New_Application> getApplicationByStatus(string status)
        {
            string DBConnect;
            DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            SqlDataAdapter da;
            DataSet ds = new DataSet();

            //create adapter
            //write sql statements

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("SELECT * FROM New_Application");
            sqlCommand.AppendLine("WHERE AppStatus = @parastatus");

            //create list to store objects
            List<New_Application> appList = new List<New_Application>();

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.SelectCommand.Parameters.AddWithValue("parastatus", status);
            da.Fill(ds, "New_Application");

            int rec_cnt = ds.Tables["New_Application"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i = 0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["New_Application"].Rows[i];
                    New_Application obj = new New_Application();
                    obj.appID = row["AppID"].ToString();
                    obj.filedDte = Convert.ToDateTime(row["FiledDte"]);
                    obj.status = row["AppStatus"].ToString();
                    obj.type = row["InsType"].ToString();
                    obj.custNric = row["Cust_NRIC_FK"].ToString();
                    obj.assStaff = row["Assess_Staff_FK"].ToString();


                    appList.Add(obj);
                }
            }

            return appList;
        }

        public List<New_Application> sortApplicationByDate(bool sort)
        {
            string DBConnect;
            DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();

            if (sort)
            {
                sqlCommand.AppendLine("SELECT * FROM New_Application");
                sqlCommand.AppendLine("WHERE AppStatus LIKE 'Pending%'");
                sqlCommand.AppendLine("ORDER BY FiledDte desc");
            }

            else
            {
                sqlCommand.AppendLine("SELECT * FROM New_Application");
                sqlCommand.AppendLine("WHERE AppStatus LIKE 'Pending%'");
                sqlCommand.AppendLine("ORDER BY FiledDte");
            }

            List<New_Application> appList = new List<New_Application>();

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);

            da.Fill(ds, "New_Application");

            int rec_cnt = ds.Tables["New_Application"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i = 0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["New_Application"].Rows[i];
                    New_Application obj = new New_Application();
                    obj.appID = row["AppID"].ToString();
                    obj.filedDte = Convert.ToDateTime(row["FiledDte"]);
                    obj.status = row["AppStatus"].ToString();
                    obj.type = row["InsType"].ToString();
                    obj.custNric = row["Cust_NRIC_FK"].ToString();
                    obj.assStaff = row["Assess_Staff_FK"].ToString();


                    appList.Add(obj);
                }
            }

            return appList;
        }

        public List<New_Application> getAllNonAssessedApplication()
        {
            string DBConnect;
            DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("select * from New_Application na");
            sqlCommand.AppendLine("where assess_Staff_FK is null;");

            List<New_Application> appList = new List<New_Application>();

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.Fill(ds, "New_Application");

            int rec_cnt = ds.Tables["New_Application"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i = 0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["New_Application"].Rows[i];
                    New_Application obj = new New_Application();
                    obj.appID = row["AppID"].ToString();
                    obj.filedDte = Convert.ToDateTime(row["FiledDte"]);
                    obj.status = row["AppStatus"].ToString();
                    obj.type = row["InsType"].ToString();
                    obj.custNric = row["Cust_NRIC_FK"].ToString();
                    obj.assStaff = row["Assess_Staff_FK"].ToString();


                    appList.Add(obj);
                }
            }

            return appList;
        }

        public List<New_Application> sortAllNonAssessedApplication(bool sort)
        {
            string DBConnect;
            DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();

            if (sort)
            {
                sqlCommand.AppendLine("SELECT * FROM New_Application");
                sqlCommand.AppendLine("WHERE assess_Staff_FK is null");
                sqlCommand.AppendLine("ORDER BY FiledDte desc");
            }

            else
            {
                sqlCommand.AppendLine("SELECT * FROM New_Application");
                sqlCommand.AppendLine("WHERE assess_Staff_FK is null");
                sqlCommand.AppendLine("ORDER BY FiledDte");
            }

            List<New_Application> appList = new List<New_Application>();

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.Fill(ds, "New_Application");

            int rec_cnt = ds.Tables["New_Application"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i = 0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["New_Application"].Rows[i];
                    New_Application obj = new New_Application();
                    obj.appID = row["AppID"].ToString();
                    obj.filedDte = Convert.ToDateTime(row["FiledDte"]);
                    obj.status = row["AppStatus"].ToString();
                    obj.type = row["InsType"].ToString();
                    obj.custNric = row["Cust_NRIC_FK"].ToString();
                    obj.assStaff = row["Assess_Staff_FK"].ToString();


                    appList.Add(obj);
                }
            }

            return appList;
        }

        public void updateApplicationByUnderwiter(string appID, string comments, decimal pRate, string staffID)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            StringBuilder sqlCommand = new StringBuilder();

            sqlCommand.AppendLine("insert into Risk_Assesment(comments, prate, assessStaff_FK, New_Application_FK)");
            sqlCommand.AppendLine("values (@paraComments, @paraPRate, @paraStaffID, @paraAppID);");

            sqlCommand.AppendLine("update new_application");
            sqlCommand.AppendLine("set appstatus = 'Pending Approval', Assess_Staff_FK = @paraStaffID");
            sqlCommand.AppendLine("where appid = @paraAppID;");

            SqlConnection myConn = new SqlConnection(DBConnect);

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd = new SqlCommand(sqlCommand.ToString(), myConn);

            sqlCmd.Parameters.AddWithValue("paraComments", comments);
            sqlCmd.Parameters.AddWithValue("paraPRate", pRate);
            sqlCmd.Parameters.AddWithValue("paraStaffID", staffID);
            sqlCmd.Parameters.AddWithValue("paraAppID", appID);

            myConn.Open();
            sqlCmd.ExecuteNonQuery();
            myConn.Close();
        }
    }
    
}