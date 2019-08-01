using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using team3.DAL;

namespace team3
{
    public partial class Sign_Up : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rdbGender_CheckedChanged(object sender, EventArgs e)
        {

        }
        private bool ValidateDataEntry()
        {
            bool result;
            LblMsg.Text = String.Empty;

            if (tbNRIC.Text == "")
            {
                LblErr.Text += "NRIC is required" + "<br/>";
            }

            if (rdblGender.SelectedIndex == -1)
            {
                LblErr.Text += "Select a gender!" + "<br/>";
            }

            if (tbEmailAddress.Text == "")
            {
                LblErr.Text += "Please enter a valid email address!" + "<br/>";
            }
            if (tbPassword.Text == "")
            {
                LblErr.Text += "please enter a password";
            }
            if (tbPassword.Text != tbCPassword.Text)
            {
                LblErr.Text += "Password does not match, please enter again!";
            }
            DateTime dob;
            result = DateTime.TryParse(tbDate.Text, out dob);
            if (result == false)
            {
                LblErr.Text += "Invalid date of birth" + "<br/>";
            }
            if (tbRAddress.Text == "")
            {
                LblErr.Text += "Please enter your residential address!" + "<br/>";
            }
            if (tbOPostalCode.Text == "")
            {
                LblErr.Text += "Please enter your residential postalcode!" + "<br/>";
            }
            if (tbNo.Text == "")
            {
                LblErr.Text += "Please enter a valid phone!" + "<br/>";
            }
            if (ddlBankName.SelectedIndex == 0)
            {
                LblErr.Text += "Please choose a bank!" + "<br/>";
            }
            if (tbAccountNo.Text == "")
            {
                LblErr.Text += "Please enter a valid bank account!" + "<br/>";
            }


            if (String.IsNullOrEmpty(LblErr.Text))
            {
                LblErr.Visible = false;
                return true;
            }
            else
            {
                return false;
            }

        }

        protected void BtnCreateCust_Click(object sender, EventArgs e)
        {
            bool result = ValidateDataEntry();

            {
                var NRIC = Convert.ToString(tbNRIC.Text);
                var Gender = Convert.ToString(rdblGender.SelectedValue);
                var Name = Convert.ToString(tbFname.Text);
                var EmailAddress = Convert.ToString(tbEmailAddress.Text);
                var Password = Convert.ToString(tbPassword.Text);
                var RAddress = Convert.ToString(tbRAddress.Text);
                var RPostCode = Convert.ToString(tbRPostalCode.Text);
                var PNo = Convert.ToString(tbNo.Text);
                var HNo = Convert.ToString(tbHNo.Text);
                var OAddress = Convert.ToString(tbOAddress.Text);
                var OPostCode = Convert.ToString(tbOPostalCode.Text);
                var ONo = Convert.ToString(tbONo.Text);
                var Bank = Convert.ToString(ddlBankName.SelectedValue);
                var DateOfBirth = Convert.ToDateTime(tbDate.Text);
                var AcNo = Convert.ToString(tbAccountNo.Text);
                var BalanceAmt = 0;


                CustomerDAO Cust = new CustomerDAO();
                Cust.InsertUser(NRIC, Gender, Name, EmailAddress, Password, RAddress,
                            RPostCode, PNo, HNo, OAddress, OPostCode,
                            ONo, Bank, DateOfBirth, AcNo, BalanceAmt);


                LblMsg.Text = "You have successfully registered as an Insurgo Client, Click the sign in below";
                LblErr.Visible = false;

            }
        }
    }
}