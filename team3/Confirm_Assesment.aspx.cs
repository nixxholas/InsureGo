using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using team3.DAL;

namespace team3
{
    public partial class Confirm_Assesment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["staffID"] = "1983719";

            if (Session["appID"] != null)
            {
                lbl_appID.Text = Session["appID"].ToString();
                lbl_Premium.Text = Session["PRate"].ToString();
                lbl_uwComment.Text = Session["UWComments"].ToString();
            }

            else
            {
                Response.Redirect("Assess_New_Application.aspx");
            }
        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Assess_Application.aspx");
        }

        protected void btn_confirm_Click(object sender, EventArgs e)
        {
            New_ApplicationDAO dao = new New_ApplicationDAO();
            dao.updateApplicationByUnderwiter(Session["appID"].ToString(), lbl_uwComment.Text, Convert.ToDecimal(lbl_Premium.Text), Session["staffID"].ToString());
            Response.Redirect("Assess_New_Application.aspx");
        }
    }
}