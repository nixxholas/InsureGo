using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace team3
{
    public partial class Quote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_Clear_Click(object sender, EventArgs e)
        {

            TB_MthlySalary.Text = "";


        }

    }
}