using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace team3
{
    public partial class InsureGo : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NRIC"] == null)
            {
                HyperLink5.Visible = true;
                HyperLink6.Visible = false;
                
            }
            else
            {
                HyperLink5.Visible = false;
                HyperLink6.Visible = true;
                
            }
        }
    }
}