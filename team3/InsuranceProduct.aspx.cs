using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using team3.DAL;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace team3
{
    public partial class InsuranceProduct : System.Web.UI.Page
    {
        string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        ProductDAO plDAO = new ProductDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                List<Product> ProductList = new List<Product>();
                ProductList = plDAO.getProduct();
                GridView_Product.DataSource = ProductList;
                GridView_Product.DataBind();
            }
        }

        protected void GridView_Product_SelectedIndexChanged(object sender, EventArgs e)
        {

            GridViewRow row = GridView_Product.SelectedRow;

            Session["productName"] = row.Cells[1].Text;
            Session["productDescription"] = row.Cells[2].Text;

            Response.Redirect("ProductDescription.aspx");


        }

        protected void BTN_Search_Click(object sender, EventArgs e)
        {

            List<Product> productList = new List<Product>();
            ProductDAO dao = new ProductDAO();
            productList = dao.filterProductType(DDL_FilterProduct.SelectedValue);
            GridView_Product.DataSource = productList;
            GridView_Product.DataBind();
        }


    }
}