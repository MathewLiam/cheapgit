using System;
using System.Collections.Generic;
using System.Text;

namespace cheapgit.DAL.Models.OracleServiceModels
{
    public class OracleProductReview
    {
        public string id { get; set; }
        public string productid { get; set; }
        public DateTime dateAdded { get; set; }
        public float durability { get; set; }
        public float product_value { get; set; }
        public float overall { get; set; }
    }
}