using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using team3.DAL;

namespace team3
{
    public partial class View_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["adminComment"] = null;

            if (Session["appID"] != null)
            {
                try
                {
                    string appID = Session["appID"].ToString();
                    View_DetailsDAO dao2 = new View_DetailsDAO();
                    var details = dao2.getDetails(appID);
                    lbl_uwcomments.Text = details.comments;
                    lbl_comments.Text = "Under Writer's Comment";
                    lbl_premium_rate.Text = details.pRate.ToString();

                    New_ApplicationDAO dao = new New_ApplicationDAO();
                    var obj = dao.getApplication(appID);
                    lbl_appID.Text = obj.appID;
                    lbl_filedDte.Text = obj.filedDte.ToShortDateString();
                    lbl_status.Text = obj.status;
                    lbl_type.Text = obj.type;
                    if (obj.assStaff == "")
                    {
                        lbl_assStaff.Text = "-";
                    }
                    else
                    {
                        lbl_assStaff.Text = obj.assStaff;
                    }
                }

                catch
                {
                    Response.Redirect("New_Application.aspx");
                }
                

            }
            else
            {
                Response.Redirect("New_Application.aspx");
            }
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("New_Application.aspx");
        }

        protected void btn_approve_Click(object sender, EventArgs e)
        {
            //View_DetailsDAO dao = new View_DetailsDAO();
            //New_ApplicationDAO dao2 = new New_ApplicationDAO();
            //var obj = dao2.getApplication(Session["appID"].ToString());
            //dao.updateStatus(true, Session["appID"].ToString(), obj.custNric, "1983719", obj.type, 200);
            Session["adminComment"] = tb_admin_comments.Text;
            Response.Redirect("Confirm_Application.aspx?status=approve");
        }

        protected void btn_reject_Click(object sender, EventArgs e)
        {
            //View_DetailsDAO dao = new View_DetailsDAO();
            //dao.updateStatus(false, Session["appID"].ToString(), null, null, null, 0);
            Session["adminComment"] = tb_admin_comments.Text;
            Response.Redirect("Confirm_Application.aspx?status=reject");
        }
    }
}