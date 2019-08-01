using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using team3.DAL;

namespace team3
{
    public partial class View_Assess_Application : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["appID"] != null)
            {
                New_ApplicationDAO dao = new New_ApplicationDAO();
                var obj = dao.getApplication(Session["appID"].ToString());
                lbl_appID.Text = obj.appID;
                lbl_filedDte.Text = obj.filedDte.ToString();
                lbl_insType.Text = obj.type;
            }

            else
            {
                Response.Redirect("Assess_New_Application.aspx");
            }
            
        }

        protected void btn_clear_Click(object sender, EventArgs e)
        {
            tb_pRate.Text = null;
            tb_uwComments.Text = null;
        }

        protected void btn_confirm_Click(object sender, EventArgs e)
        {
            if (tb_pRate.Text != null || tb_pRate.Text != "")
            {
                if (tb_uwComments.Text != null || tb_uwComments.Text != "")
                {
                    if (Page.IsValid)
                    {
                        Session["PRate"] = tb_pRate.Text;
                        Session["UWComments"] = tb_uwComments.Text;
                        Response.Redirect("Confirm_Assesment.aspx");
                    }

                    else
                    {
                        RequiredFieldValidator2.Visible = false;
                        Validate();
                    }
                }
                else
                {
                    Validate();
                }
            }
            else
            {
                Validate();
                //btn_confirm.CssClass = "btn btn-outline-success disabled";
            }
        }

        protected void PRate_ServerValidation(object source, ServerValidateEventArgs args)
        {
            try
            {
                Convert.ToDecimal(tb_pRate.Text);
                args.IsValid = true;
                
            }
            catch
            {
                args.IsValid = false;
            }

        }
    }
}