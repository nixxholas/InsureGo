using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using team3.DAL;

namespace team3
{
    public partial class Notifications : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Initialise the object first...
            var DAO = new NotificationsDAO();

            // Call the primitive SQL Query
            var res = DAO.getNotification(Session["NRIC"].ToString());

            // EZ
            GridView1.DataSource = res;
        }
    }
}