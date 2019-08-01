using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace team3.DAL
{
    public class New_Application
    {
        public New_Application()
        {
        }

        public string appID { get; set; }
        public string status { get; set; }
        public DateTime filedDte { get; set; }
        public string type { get; set; }
        public string custNric { get; set; }
        public string assStaff { get; set; }
        
    }
}