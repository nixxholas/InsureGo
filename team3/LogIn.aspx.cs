using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using team3.DAL;

namespace team3
{
    public partial class LogIn : System.Web.UI.Page
    {
        string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void BtnSignIn_Click1(object sender, EventArgs e)
        {
            /*string check = "select count (*) from [Customer] where NRIC=" + tbNRIC.Text + "and Password=" + tbPassword.Text;
            SqlCommand con = new SqlCommand();
            con.Open();
            */


            var Username = Convert.ToString(tbNRIC.Text);
            var Password = Convert.ToString(tbPassword.Text);
            LblErr.Visible = true;
            LblErr.Text = Username + Password;

            CustomerDAO DAO = new CustomerDAO();
            int result = DAO.ValidateSignIn(Username, Password);

            LblErr.Text = Convert.ToString(result);
            if (result == 0)
            {
                LblErr.Visible = true;
                LblErr.Text = "User does not exist, please try again or sign up! ";
            }
            else if (result == 1)
            {
                Session["NRIC"] = tbNRIC.Text;
                Response.Redirect("Home.aspx");
            }
            /*
           Session["NRIC"] = "T0117772E";
           Response.Redirect("~/GoWallet.aspx");

       */

        }
    }
}