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
    public partial class Recommendation : System.Web.UI.Page
    {
        string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void GridView_Recommendation_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView_Reccomendation.SelectedRow;

            Session["productName"] = row.Cells[1].Text;
            Session["productDescription"] = row.Cells[2].Text;

            Response.Redirect("ProductDescription.aspx");
        }
    }
}