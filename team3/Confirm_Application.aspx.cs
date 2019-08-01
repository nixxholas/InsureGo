using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using team3.DAL;

namespace team3
{
    public partial class Confirm_Application : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["adminID"] = "1983719";

            if (Session["appID"] != null)
            {
                string appID = Session["appID"].ToString();
                New_ApplicationDAO dao = new New_ApplicationDAO();
                var obj = dao.getApplication(appID);
                lbl_appID.Text = obj.appID;

                View_DetailsDAO dao2 = new View_DetailsDAO();
                var obj2 = dao2.getDetails(appID);
                lbl_uwComment.Text = obj2.comments;
                lbl_Premium.Text = obj2.pRate.ToString();

                if (Session["adminComment"] != null)
                {
                    lbl_adminComment.Text = Session["adminComment"].ToString();
                }
                else
                {
                    lbl_adminComment.Text = "";
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
                Response.Redirect("New_Application.aspx");
            }
        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Details.aspx");
        }

        protected void btn_approve_Click(object sender, EventArgs e)
        {
            var adminID = Session["adminID"].ToString();
            var adminComment = lbl_adminComment.Text;

            View_DetailsDAO dao = new View_DetailsDAO();
            New_ApplicationDAO dao2 = new New_ApplicationDAO();

            var obj = dao2.getApplication(Session["appID"].ToString());

            dao.updateStatus(true, Session["appID"].ToString(), obj.custNric, adminID, obj.type, Convert.ToDecimal(lbl_Premium.Text), adminComment);
            Response.Redirect("New_Application.aspx");
        }

        protected void btn_reject_Click(object sender, EventArgs e)
        {
            var adminComment = lbl_adminComment.Text;
            View_DetailsDAO dao = new View_DetailsDAO();

            dao.updateStatus(false, Session["appID"].ToString(), null, null, null, 0, adminComment);
            Response.Redirect("New_Application.aspx");
        }
    }
}