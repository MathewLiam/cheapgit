using System;
using System.Collections.Generic;
using System.Text;

namespace cheapgit.DAL.Models
{
    class OrderItem
    {
        public int id { get; set; }
        public string orderid { get; set; }
        public int productid { get; set; }
        public int quantity { get; set; }
        public float cumulativeValue { get; set; }

        public virtual Order order { get; set; }
        public virtual Product product { get; set; }
    }
}
