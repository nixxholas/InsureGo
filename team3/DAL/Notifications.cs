using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace team3.DAL
{
    public class Notifications
    {
        public Notifications()
        {
        }
        public string Notification { get; set; }
        public string Message { get; set; }
        public DateTime date { get; set; }
        public string NRIC { get; set; }

    }
}