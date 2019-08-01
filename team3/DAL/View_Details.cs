using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace team3.DAL
{
    public class View_Details
    {
        public View_Details()
        {
        }

        public string refID { get; set; }
        public string comments { get; set; }
        public double pRate { get; set; }
        public string adminComment { get; set; }

    }
}