using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using team3.DAL;

namespace team3
{
    public partial class New_Application : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                New_ApplicationDAO dao = new New_ApplicationDAO();
                var appList = dao.getAllNewApplication();
                GridView1.DataSource = appList;
                GridView1.DataBind();
            }
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //New_ApplicationDAO dao = new New_ApplicationDAO();
            Session["appID"] = GridView1.SelectedValue.ToString();
            //Session["appID"] = GridView1.SelectedRow.Cells[0].Text;
            Response.Redirect("View_Details.aspx");
        }

        protected void FilterBtn_Click(object sender, EventArgs e)
        {
            New_ApplicationDAO dao = new New_ApplicationDAO();
            var appList = dao.searchByAppNo(Search.Text);
            if (appList == null)
            {
                Response.Redirect("New_Application.aspx");
            }
            else
            {
                GridView1.DataSource = appList;
                GridView1.DataBind();
            }
        }

        protected void ddl_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_Type.SelectedIndex != 0)
            {
                New_ApplicationDAO dao = new New_ApplicationDAO();
                var appList = dao.getApplicationByType(ddl_Type.SelectedValue);
                GridView1.DataSource = appList;
                GridView1.DataBind();
            }
            else
            {
                Response.Redirect("New_Application.aspx");
            }
        }

        protected void StatusDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusDdl.SelectedIndex != 0)
            {
                New_ApplicationDAO dao = new New_ApplicationDAO();
                var appList = dao.getApplicationByStatus(StatusDdl.SelectedValue);
                GridView1.DataSource = appList;
                GridView1.DataBind();
            }
            else
            {
                Response.Redirect("New_Application.aspx");
            }
        }

        protected void SortingDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            New_ApplicationDAO dao = new New_ApplicationDAO();

            if (SortingDdl.SelectedIndex == 0)
            {
                var appList = dao.sortApplicationByDate(true);
                GridView1.DataSource = appList;
                GridView1.DataBind();
            }
            else
            {
                var appList = dao.sortApplicationByDate(false);
                GridView1.DataSource = appList;
                GridView1.DataBind();
            }

        }
    }
}