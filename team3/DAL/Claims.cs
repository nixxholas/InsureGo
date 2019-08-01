using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace team3.DAL
{
    public class Claims
    {
        public Claims()
        {
        }
        public string ClaimID { get; set; }
        public float ClaimAmt { get; set; }
        public DateTime FiledDte { get; set; }
        public string Remarks { get; set; }
        public string ClaimStatus { get; set; }
        public string Location { get; set; }
        public DateTime IncidentDate { get; set; }
        public string DisabilityType { get; set; }
        public string DeceasedName { get; set; }
        public string DeceasedNRIC { get; set; }
    }
}