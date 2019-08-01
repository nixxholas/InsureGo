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
    public partial class Home : System.Web.UI.Page
    {
        string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string logout = Request.QueryString["logout"];
                if (logout == "true")
                {
                    Session.Clear();
                }
                
                //Session.Clear();
            }
            catch
            {
                Response.Redirect("Home.aspx");
            }

            if (Session["NRIC"] != null)
            {
                CustomerDAO dao = new CustomerDAO();
                var obj = dao.FindName(Session["NRIC"].ToString());
                string name = obj.Name;
                lbl_name.Text = name;
            }

            else
            {
                lbl_name.Text = "Welcome To InsureGo";
            }
            
        }

        protected void BTN_Filter_Click(object sender, EventArgs e)
        {
            GridView_Reccomendation.Visible = true;

            List<Product> productList = new List<Product>();
            ProductDAO dao = new ProductDAO();
            productList = dao.recoProducts(DDL_ProductPremiumReco.SelectedValue);
            GridView_Reccomendation.DataSource = productList;
            GridView_Reccomendation.DataBind();

        }

    }
}