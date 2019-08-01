using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace team3.DAL
{
    public class All_Policies
    {
        public All_Policies()
        {
        }

        public string PolicyNum { get; set; }
        public string PolicyType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime MaturedDate { get; set; }
        public Decimal PremiumAmt { get; set; }
        public string CustomerNRIC { get; set; }
        public string ApproveStaff { get; set; }
        public string uwComments { get; set; }
        public string adminComments { get; set; }
    }
}