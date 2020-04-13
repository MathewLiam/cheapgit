using System;
using System.Collections.Generic;
using System.Text;

namespace cheapgit.DAL.Models
{
    class OrderAddress
    {
        public int id { get; set; }
        public string addressln1 { get; set; }
        public string addressln2 { get; set; }
        public string addressln3 { get; set; }
        public string town_city { get; set; }
        public string county { get; set; }
        public string country { get; set; }
        public string postcode { get; set; }
        public string orderid { get; set; }

        public virtual Order order { get; set; }
    }
}
