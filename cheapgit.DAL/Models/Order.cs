using System;
using System.Collections.Generic;
using System.Text;

namespace cheapgit.DAL.Models
{
    class Order
    {
        public string id { get; set; }
        public string customerid { get; set; }
        public DateTime orderdate { get; set; }
        public string status { get; set; }

        public virtual Customer customer { get; set; }
    }
}
