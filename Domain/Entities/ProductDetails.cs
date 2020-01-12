using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductDetails
    {
        public string ProductName { get; set; }
        public string Discount { get; set; }
        public string Price { get; set; }
        public Uri WebSite { get; set; }
        public DateTime ListingDate { get; set; }
        public string Keyword { get; set; }


    }
}
