using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace team3.DAL
{
    public class Product
    {
        public Product()
        {
        }

            public int productId { get; set; }
            public string productName { get; set; }
            public string productPremium { get; set; }
            public string productDescription { get; set; }
            public string productType { get; set; }
            public string productPeriod { get; set; }
    }
}