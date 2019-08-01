using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace team3.DAL
{
    public class Customer
    {
        public Customer()
        {

        }

        public string NRIC { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        private string Password { get; set; }
        public string RAddress { get; set; }
        public string RPostCode { get; set; }
        public string PNo { get; set; }
        public string HNo { get; set; }
        public string OAddress { get; set; }
        public string OPostCode { get; set; }
        public string ONo { get; set; }
        public string Bank { get; set; }
        public string AcNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string WalletID { get; set; }
        public string BalanceAmt { get; set; }
    }
}