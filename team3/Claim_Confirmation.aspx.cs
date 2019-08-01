using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using team3.DAL;

namespace team3
{
    public partial class Claim_Confirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["adminID"] = "1983719";

            if (Session["ClaimID"] != null)
            {
                string ClaimID = Session["ClaimID"].ToString();

                Claim_ApplicationDAO dao = new Claim_ApplicationDAO();
                var obj = dao.getClaimApplication(ClaimID);

                lbl_ClaimID.Text = obj.ClaimID;
                lbl_ClaimAmt.Text = obj.ClaimAmt.ToString();
                lbl_uwComment.Text = obj.uwComment;

                if (Session["adminComment"] != null)
                {
                    lbl_AdminComment.Text = Session["adminComment"].ToString();
                }
                else
                {
                    lbl_AdminComment.Text = "";
                }

                string status = Request.QueryString["status"];
                lbl_status.Text = status;

                if (status == "approve")
                {
                    btn_approve.Visible = true;
                    btn_reject.Visible = false;
                }
                else
                {
                    btn_reject.Visible = true;
                    btn_approve.Visible = false;
                }
            }
            else
            {
                Response.Redirect("Claim_Application.aspx");
            }
        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Claim_Application.aspx");
        }

        protected void btn_approve_Click(object sender, EventArgs e)
        {
            Claim_ApplicationDAO dao = new Claim_ApplicationDAO();
            var obj = dao.getClaimApplication(Session["ClaimID"].ToString());
            var policynum = obj.PolicyNum;

            dao.updateClaim(true, lbl_ClaimID.Text, lbl_AdminComment.Text, policynum, Session["adminID"].ToString());

            Response.Redirect("Claim_Application.aspx");
        }

        protected void btn_reject_Click(object sender, EventArgs e)
        {
            Claim_ApplicationDAO dao = new Claim_ApplicationDAO();

            dao.updateClaim(false, lbl_ClaimID.Text, lbl_AdminComment.Text, null, Session["adminID"].ToString());

            Response.Redirect("Claim_Application.aspx");

        }
    }
}