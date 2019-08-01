using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using team3.DAL;

namespace team3
{
    public partial class View_Claim_Application : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            panel_Disability.Visible = false;
            panel_Life.Visible = false;

            if (Session["ClaimID"] != null)
            {
                Claim_ApplicationDAO dao = new Claim_ApplicationDAO();
                var obj = dao.getClaimApplication(Session["ClaimID"].ToString());

                lbl_ClaimID.Text = obj.ClaimID;
                lbl_ClaimAmount.Text = obj.ClaimAmt.ToString();
                lbl_FiledDte.Text = obj.FiledDte.ToString();
                lbl_IncidentDate.Text = obj.IncidentDate.ToString();
                lbl_Location.Text = obj.Location;
                lbl_PolicyType.Text = obj.PolicyType;
                lbl_Status.Text = obj.ClaimStatus;
                lbl_uwComment.Text = obj.uwComment;

                if (obj.PolicyType == "Disability")
                {
                    panel_Disability.Visible = true;
                    lbl_DisabilityType.Text = obj.DisabilityType;
                }

                else if (obj.PolicyType == "Life")
                {
                    panel_Life.Visible = true;
                    lbl_DeceasedName.Text = obj.DeceasedName;
                    lbl_DeceasedNRIC.Text = obj.DeceasedNRIC;
                }
            }
            else
            {
                Response.Redirect("Claim_Application.aspx");
            }
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Claim_Application.aspx");
        }

        protected void btn_reject_Click(object sender, EventArgs e)
        {
            Response.Redirect("Claim_Confirmation.aspx?status=reject");
        }

        protected void btn_approve_Click(object sender, EventArgs e)
        {
            Response.Redirect("Claim_Confirmation.aspx?status=approve");
        }
    }
}