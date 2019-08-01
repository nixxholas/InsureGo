using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using team3.DAL;

namespace team3
{
    public partial class Assess_New_Application : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                New_ApplicationDAO dao = new New_ApplicationDAO();
                var appList = dao.getAllNonAssessedApplication();
                GridView1.DataSource = appList;
                GridView1.DataBind();
            }
        }

        protected void ddl_sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            New_ApplicationDAO dao = new New_ApplicationDAO();
            if (ddl_sort.SelectedIndex == 1)
            {
                var appList = dao.sortAllNonAssessedApplication(true);
                GridView1.DataSource = appList;
                GridView1.DataBind();
            }
            else if (ddl_sort.SelectedIndex == 2)
            {
                var appList = dao.sortAllNonAssessedApplication(false);
                GridView1.DataSource = appList;
                GridView1.DataBind();
            }
            else
            {
                var appList = dao.getAllNonAssessedApplication();
                GridView1.DataSource = appList;
                GridView1.DataBind();
            }
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["appID"] = GridView1.SelectedValue.ToString();
            Response.Redirect("View_Assess_Application.aspx");
        }
    }
}