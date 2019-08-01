using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using team3.DAL;

namespace team3
{
    public partial class GoWallet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["NRIC"] = "S7832692B";

            if (Session["NRIC"] != null)
            {
                Balance.Text = "";
                var Wallet_ID = Session["NRIC"].ToString();

                CustomerDAO DAO = new CustomerDAO();
                var Name = DAO.FindName(Wallet_ID);
                LbGreeting.Text = "Welcome " + Name.Name + " Your GoWallet left:";

                TransferFundDAO TF = new TransferFundDAO();
                var obj = TF.getBalance(Wallet_ID);
                Balance.Text = "$" + obj.BalanceAmt;
            }
            else if (Session["NRIC"] == null)
            {
                Response.Redirect("~/LogIn.aspx");
            }





        }

        protected void BtnSendBank_Click(object sender, EventArgs e)
        {
            var Amt = Convert.ToDouble(tbSendBk.Text);
            var TransactionType = "Send to bank";
            var WalletID = Session["NRIC"].ToString();
            var TransactionDte = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");


            TransferFundDAO TF = new TransferFundDAO();
            var obj = TF.getBalance(WalletID);
            var TransactionID = Convert.ToInt16(TF.getTransactionID(WalletID));


            TF.ComputenewBalance2(obj.BalanceAmt, Amt,
                TransactionDte, TransactionType, WalletID, TransactionID);
            Response.Redirect(Request.Url.ToString());
        }

        protected void BtnTopUp_Click(object sender, EventArgs e)
        {
            var Amt = Convert.ToDouble(TBTopUp.Text);
            var TransactionDte = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
            var WalletID = Session["NRIC"].ToString();
            var TransactionType = "TopUp";


            TransferFundDAO TF = new TransferFundDAO();

            var obj = TF.getBalance(WalletID);
            var TransactionID = Convert.ToInt16(TF.getTransactionID(WalletID));

            TF.ComputenewBalance1(obj.BalanceAmt, Amt,
                TransactionDte, TransactionType, WalletID, TransactionID);
            Response.Redirect(Request.Url.ToString());
        }

        protected void BtnPay_Click(object sender, EventArgs e)
        {
            var Amt = Convert.ToDouble(tbPay.Text);
            var TransactionType = "Pay to " + DropDownList1.SelectedValue;
            var WalletID = Session["NRIC"].ToString();
            var TransactionDte = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");


            TransferFundDAO TF = new TransferFundDAO();
            var obj = TF.getBalance(WalletID);
            var TransactionID = Convert.ToInt16(TF.getTransactionID(WalletID));

            TF.ComputenewBalance2(obj.BalanceAmt, Amt,
                TransactionDte, TransactionType, WalletID, TransactionID);
            Response.Redirect(Request.Url.ToString());
        }
    }
}