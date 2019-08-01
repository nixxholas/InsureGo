using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using team3.DAL;

namespace team3
{
    public partial class Claim_Application : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                Claim_ApplicationDAO dao = new Claim_ApplicationDAO();
                var claimList = dao.getAllClaimApplication();
                GridView1.DataSource = claimList;
                GridView1.DataBind();
            }
                
        }

        protected void FilterBtn_Click(object sender, EventArgs e)
        {
            Claim_ApplicationDAO dao = new Claim_ApplicationDAO();
            var claimList = dao.searchByClaimID(Search.Text);
            GridView1.DataSource = claimList;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["ClaimID"] = null;
            Session["ClaimID"] = GridView1.SelectedDataKey.Value;
            Response.Redirect("View_Claim_Application.aspx");
        }

        protected void ddl_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Claim_ApplicationDAO dao = new Claim_ApplicationDAO();
            var claimList = dao.filterByPolicyType(ddl_Type.SelectedValue);
            GridView1.DataSource = claimList;
            GridView1.DataBind();
        }

        protected void StatusDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Claim_ApplicationDAO dao = new Claim_ApplicationDAO();
            var claimList = dao.filterByClaimStatus(StatusDdl.SelectedValue);
            GridView1.DataSource = claimList;
            GridView1.DataBind();
        }

        protected void SortingDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Claim_ApplicationDAO dao = new Claim_ApplicationDAO();

            if (SortingDdl.SelectedIndex == 0)
            {
                var claimList = dao.sortApplicationByDate(true);
                GridView1.DataSource = claimList;
                GridView1.DataBind();
            }
            else
            {
                var claimList = dao.sortApplicationByDate(false);
                GridView1.DataSource = claimList;
                GridView1.DataBind();
            }
        }
    }
}