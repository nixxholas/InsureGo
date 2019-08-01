using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using team3.DAL;

namespace team3
{
    public partial class All_Policies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                All_PoliciesDAO dao = new All_PoliciesDAO();
                var polList = dao.getAllPolicies();
                GridView1.DataSource = polList;
                GridView1.DataBind();
            }
        }

        protected void ddl_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            All_PoliciesDAO dao = new All_PoliciesDAO();

            if (ddl_Status.SelectedIndex == 1)
            {
                var polList = dao.getActivePolicies();
                GridView1.DataSource = polList;
                GridView1.DataBind();
            }

            else if (ddl_Status.SelectedIndex == 2)
            {
                var polList = dao.getExpiredPolicies();
                GridView1.DataSource = polList;
                GridView1.DataBind();
            }
            
        }

        protected void btn_Filter_Click(object sender, EventArgs e)
        {
            string polno = tb_Search.Text;
            string nric = tb_cust.Text;

            All_PoliciesDAO dao = new All_PoliciesDAO();
            if (polno != "")
            {
                tb_cust.Text = "";
                var polList = dao.searchByPolicyNum(polno);
                GridView1.DataSource = polList;
                GridView1.DataBind();
            }

            if (nric != "")
            {
                tb_Search.Text = "";
                var polList = dao.searchByNRIC(nric);
                GridView1.DataSource = polList;
                GridView1.DataBind();
            }

            if (polno == "" && nric == "")
            {
                Response.Redirect("All_Policies.aspx");
            }
            
        }

        protected void ddl_sorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_sorting.SelectedIndex == 1)
            {
                All_PoliciesDAO dao = new All_PoliciesDAO();
                var polList = dao.filterByDate(true);
                GridView1.DataSource = polList;
                GridView1.DataBind();
            }
            else
            {
                All_PoliciesDAO dao = new All_PoliciesDAO();
                var polList = dao.filterByDate(false);
                GridView1.DataSource = polList;
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["PolicyNum"] =  GridView1.SelectedDataKey.Value.ToString();
            Response.Redirect("View_Policies_Details.aspx");
        }
    }
}