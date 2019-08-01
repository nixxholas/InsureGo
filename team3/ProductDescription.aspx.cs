using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace team3
{
    public partial class ProductDescription : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Lbl_ProductName.Text = Session["productName"].ToString();
            Lbl_ProductDescription.Text = Session["productDescription"].ToString();
        }

        protected void Btn_Submit_Click(object sender, EventArgs e)
        {
            //Lbl_ProductName.Text = Session["productName"].ToString();
            //Session["productName"] = "GoMedi";

            string d = Session["productName"].ToString();

            if (Session["productName"].ToString() == "GoMedi                                            ")
            {
                Panel_Medical.Visible = true;
                Panel_Endowment.Visible = false;
            }

            else if (Lbl_ProductName.Text == "GoSavings                                         ")
            {
                Panel_Medical.Visible = false;
                Panel_Endowment.Visible = true;
            }

            else
            {
                Panel_Medical.Visible = false;
                Panel_Endowment.Visible = false;
            }

        }
    }
}