using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using team3.DAL;

namespace team3
{
    public partial class Claims : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NRIC"] != null)
            {

                Session["userDeceasedName"] = "";
                Session["userDeceasedNRIC"] = "";
                Session["userDateOfDeath"] = "";
                Session["userDisability"] = "";
                Session["userOthers"] = "";
                Session["location"] = "";
                Session["userLocation"] = "";
                Session["userDate"] = "";
                Session["userDescription"] = "";

                if (!Page.IsPostBack)
                {
                    List<string> countries = new List<string>();
                    CultureInfo[] culture = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
                    foreach (CultureInfo item in culture)
                    {
                        RegionInfo region = new RegionInfo(item.LCID);
                        if (!(countries.Contains(region.EnglishName)))
                        {
                            countries.Add(region.EnglishName);
                        }
                    }
                    countries.Sort();
                    DropDownList2.DataSource = countries;
                    DropDownList2.DataBind();

                    //Session["NRIC"] = "S7832692B";

                    CustomerDAO obj = new CustomerDAO();
                    var obj2 = obj.FindName(Session["NRIC"].ToString());
                    string name = obj2.Name;

                    if (Session["NRIC"] != null)
                    {
                        var NRIC = Session["NRIC"].ToString();
                        //ClaimsDAO dao = new ClaimsDAO();
                        //var name = dao.getName(NRIC);
                        Nametext1.Text = name;
                        NRICtext1.Text = NRIC;
                        Nametext2.Text = name;
                        NRIC2.Text = NRIC;
                        Nametext3.Text = name;
                        NRIC3.Text = NRIC;

                    }
                }
            }

            else if (Session["NRIC"] == null)
            {
                Response.Redirect("~/LogIn.aspx");
            }

        }

        protected void Okaybutton_Click(object sender, EventArgs e)
        {
            /*if (DropDownList1.SelectedItem.Text == "Medical Benefits")
            {
                Medbenefits.Visible = true;
                travelruption.Visible = false;
                Disabilities.Visible = false;
                Deathsurance.Visible = false;
            }
            else if (DropDownList1.SelectedItem.Text == "Travel disruption")
            {
                travelruption.Visible = true;
                Medbenefits.Visible = false;
                Disabilities.Visible = false;
                Deathsurance.Visible = false;
            }
            else if (DropDownList1.SelectedItem.Text == "Total & permanent disability")
            {
                Disabilities.Visible = true;
                Medbenefits.Visible = false;
                travelruption.Visible = false;
                Deathsurance.Visible = false;
            }
            else if (DropDownList1.SelectedItem.Text == "Death")
            {
                Deathsurance.Visible = true;
                Medbenefits.Visible = false;
                travelruption.Visible = false;
                Disabilities.Visible = false;
            }*/

            if (DropDownList4.SelectedValue == "Medical                       ")
            {
                Medbenefits.Visible = true;
                travelruption.Visible = false;
                Disabilities.Visible = false;
                Deathsurance.Visible = false;
            }
            else if (DropDownList4.SelectedValue == "Travel                        ")
            {
                travelruption.Visible = true;
                Medbenefits.Visible = false;
                Disabilities.Visible = false;
                Deathsurance.Visible = false;
            }
            else if (DropDownList4.SelectedValue == "Disability                    ")
            {
                Disabilities.Visible = true;
                Medbenefits.Visible = false;
                travelruption.Visible = false;
                Deathsurance.Visible = false;
            }
        
            else if (DropDownList4.SelectedValue == "Life                          ")
            {
                Deathsurance.Visible = true;
                Medbenefits.Visible = false;
                travelruption.Visible = false;
                Disabilities.Visible = false;
            }
        }

        protected void confirmation2_Click(object sender, EventArgs e)
        {
            Session["username"] = Nametext2.Text;
            Session["FiledDate"] = DateTime.Now;
            Session["userNRIC"] = NRIC2.Text;
            Session["userLocation"] = DropDownList2.SelectedValue;
            Session["userDescription"] = TextBox1.Text;
            Session["userDate"] = Calendar2.SelectedDate;
            Session["Type"] = "2";
            Session["PolicyNum"] = DropDownList6.SelectedValue;

            Response.Redirect("Confirmation.aspx");
        }

        protected void comfirmation1_Click(object sender, EventArgs e)
        {
            Session["username"] = Nametext1.Text;
            Session["userNRIC"] = NRICtext1.Text;
            Session["FiledDate"] = DateTime.Now;
            Session["userDate"] = Calendar3.SelectedDate;
            Session["userDescription"] =incidenttext.Text;
            Session["Type"] = "1";
            Session["PolicyNum"] = DropDownList5.SelectedValue;

            Response.Redirect("Confirmation.aspx");
        }

        protected void Confirmation3_Click(object sender, EventArgs e)
        {
            Session["username"] = Nametext3.Text;
            Session["userNRIC"] = NRIC3.Text;
            Session["FiledDate"] = DateTime.Now;
            Session["userDisability"] = DropDownList3.SelectedValue;
            Session["userOthers"] = specify1.Text;
            Session["Type"] = "3";
            Session["PolicyNum"] = DropDownList7.SelectedValue;
            Session["userDate"] = Calendar5.SelectedDate;

            Response.Redirect("Confirmation.aspx");
        }

        protected void Confirmation4_Click(object sender, EventArgs e)
        {
            Session["username"] = string.Empty;
            Session["userNRIC"] = string.Empty;
            Session["userDeceasedName"] = Nametext4.Text;
            Session["userDeceasedNRIC"] = NRIC4.Text;
            Session["FiledDate"] = DateTime.Now;
            Session["userDateOfDeath"] = Calendar4.SelectedDate;
            Session["Type"] = "4";
            Session["PolicyNum"] = DropDownList8.SelectedValue;

            Response.Redirect("Confirmation.aspx");
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}