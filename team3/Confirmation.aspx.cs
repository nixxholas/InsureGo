using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using team3.DAL;

namespace team3
{
    public partial class Confirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;

            Label_Name.Text = Session["username"].ToString();
            Label_NRIC.Text = Session["userNRIC"].ToString();
            Label_Description.Text = Session["userDescription"].ToString();
            Label_Date1.Text = Session["userDate"].ToString();
            Label_Name2.Text = Session["username"].ToString();
            Label_NRIC2.Text = Session["userNRIC"].ToString();
            Label_Location.Text = Session["userLocation"].ToString();
            Label_Description2.Text = Session["userDescription"].ToString();
            Label_Date.Text = Session["userDate"].ToString();
            Label_Name3.Text = Session["username"].ToString();
            Label_NRIC3.Text = Session["userNRIC"].ToString();
            Label_Date3.Text = Session["userDate"].ToString();
            Label_Disability.Text = Session["userDisability"].ToString();
            Label_Others.Text = Session["userOthers"].ToString();
            Label_DeceasedName.Text = Session["userDeceasedName"].ToString();
            Label_DeceasedNRIC.Text = Session["userDeceasedNRIC"].ToString();
            Label_DateOfDeath.Text = Session["userDateOfDeath"].ToString();

            if (Session["Type"].ToString() == "1")
            {
                Panel1.Visible = true;
            }
            else if (Session["Type"].ToString() == "2")
            {
                Panel2.Visible = true;
            }
            else if (Session["Type"].ToString() == "3")
            {
                Panel3.Visible = true;
            }
            else if (Session["Type"].ToString() == "4")
            {
                Panel4.Visible = true;
            }
        }

        protected void backbutton1_Click(object sender, EventArgs e)
        {
            var Name = Session["username"].ToString();
            var NRIC = Session["userNRIC"].ToString();
            var UserDesc = Session["userDescription"].ToString();
            var PolicyNum = Session["PolicyNum"].ToString();
            var Date = Session["userDate"].ToString();
            Response.Redirect("Claims.aspx");
        }

        protected void backbutton2_Click(object sender, EventArgs e)
        {
            var Name = Session["username"].ToString();
            var NRIC = Session["userNRIC"].ToString();
            var UserDesc = Session["userDescription"].ToString();
            var Location = Session["userLocation"].ToString();
            var PolicyNum = Session["PolicyNum"].ToString();
            var Date = Session["userDate"].ToString();
            Response.Redirect("Claims.aspx");
        }

        protected void backbutton3_Click(object sender, EventArgs e)
        {

        
            Response.Redirect("Claims.aspx");
        }

        protected void backbutton4_Click(object sender, EventArgs e)
        {
       
            Response.Redirect("Claims.aspx");
        }

        protected void submitbutton1_Click(object sender, EventArgs e)
        {       
            
            var Date = Convert.ToDateTime(Session["FiledDate"]);
            var Remarks = Session["userDescription"].ToString();
            var ClaimStatus = "Pending";
            var Location = Session["userLocation"].ToString();
            var IncidentTime = Convert.ToDateTime(Session["userDate"].ToString());
            var DisabilityType = "";
            var Deceasedname = "";
            var DeceasedNRIC ="" ;
            int PolicyNum = Convert.ToInt32(Session["PolicyNum"].ToString());

            ClaimsDAO DAO = new ClaimsDAO();

            DAO.InsertClaim(Date, Remarks, ClaimStatus, Location, IncidentTime,
                        DisabilityType, Deceasedname, DeceasedNRIC, PolicyNum);
            Response.Redirect("Submission.aspx");
        }

        protected void submitbutton2_Click(object sender, EventArgs e)
        {
            var Date = Convert.ToDateTime(Session["FiledDate"]);
            var Remarks = Session["userDescription"].ToString();
            var ClaimStatus = "Pending";
            var Location = Session["userLocation"].ToString();
            var IncidentTime = Convert.ToDateTime(Session["userDate"].ToString());
            var DisabilityType = "";
            var Deceasedname = "";
            var DeceasedNRIC = "";
            int PolicyNum = Convert.ToInt32(Session["PolicyNum"].ToString());

            ClaimsDAO DAO = new ClaimsDAO();

            DAO.InsertClaim(Date, Remarks, ClaimStatus, Location, IncidentTime,
                        DisabilityType, Deceasedname, DeceasedNRIC, PolicyNum);

            Response.Redirect("Submission.aspx");
        }

        protected void submitbutton3_Click(object sender, EventArgs e)
        {
            var Date = Convert.ToDateTime(Session["FiledDate"]);
            var Remarks = Session["userDescription"].ToString();
            var ClaimStatus = "Pending";
            var Location = "";
            var IncidentTime = Convert.ToDateTime(Session["userDate"]);
            var DisabilityType = Convert.ToString(Session["userDisability"]);
            var Deceasedname = "";
            var DeceasedNRIC = "";
            int PolicyNum = Convert.ToInt32(Session["PolicyNum"].ToString());

            ClaimsDAO DAO = new ClaimsDAO();

            DAO.InsertClaim(Date, Remarks, ClaimStatus, Location, IncidentTime,
                        DisabilityType, Deceasedname, DeceasedNRIC, PolicyNum);

            Response.Redirect("Submission.aspx");
        }

        protected void submitbutton4_Click(object sender, EventArgs e)
        {
            var Date = Convert.ToDateTime(Session["FiledDate"]);
            var Remarks = "";
            var ClaimStatus = "Pending";
            var Location = "";
            var IncidentTime = Convert.ToDateTime(Session["userDateOfDeath"].ToString());
            var DisabilityType = "";
            var Deceasedname = Convert.ToString(Session["userDeceasedName"]);
            var DeceasedNRIC = Convert.ToString(Session["userDeceasedNRIC"]);
            int PolicyNum = Convert.ToInt32(Session["PolicyNum"].ToString());

            ClaimsDAO DAO = new ClaimsDAO();

            DAO.InsertClaim(Date, Remarks, ClaimStatus, Location, IncidentTime,
                        DisabilityType, Deceasedname, DeceasedNRIC, PolicyNum);

            Response.Redirect("Submission.aspx");
        }
    }
}