using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using team3.DAL;

namespace team3
{
    public partial class View_Policies_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PolicyNum"] != null)
            {
                string policynum = Session["PolicyNum"].ToString();
                All_PoliciesDAO dao = new All_PoliciesDAO();
                var obj = dao.getPolicyDetails(policynum);
                lbl_MaturedDate.Text = obj.MaturedDate.ToString();
                lbl_NRIC.Text = obj.CustomerNRIC;
                lbl_PolicyNum.Text = obj.PolicyNum;
                lbl_PolicyType.Text = obj.PolicyType;
                lbl_PRate.Text = obj.PremiumAmt.ToString();
                lbl_StartDate.Text = obj.StartDate.ToString();
                lbl_uwComments.Text = obj.uwComments;

                if (obj.adminComments == null)
                {
                    lbl_AdminComments.Text = "";
                }
                else
                {
                    lbl_AdminComments.Text = obj.adminComments;
                }
            }
            else
            {
                Response.Redirect("All_Policies.aspx");
            }
           
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("All_Policies.aspx");
        }

        protected void btn_renew_Click(object sender, EventArgs e)
        {
            panel_renewal.Visible = true;
            btn_renew.Visible = false;
            btn_confirm.Visible = true;
        }

        protected void btn_confirm_Click(object sender, EventArgs e)
        {
            int tenor = Convert.ToInt32(ddl_renew_term.SelectedValue);
            All_PoliciesDAO dao = new All_PoliciesDAO();
            dao.updatePolicyPeriod(tenor, lbl_PolicyNum.Text);
            Response.Redirect("All_Policies.aspx");
        }
    }
}