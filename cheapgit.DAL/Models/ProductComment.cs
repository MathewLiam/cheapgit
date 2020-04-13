using System;
using System.Collections.Generic;
using System.Text;

namespace cheapgit.DAL.Models
{
    public class ProductComment
    {
        public string id { get; set; }
        public string productid { get; set; }
        public DateTime dateAdded { get; set; }
        public string commentTitle { get; set; }
        public string commentBody { get; set; }
        public int flaggedInappropriate { get; set; }
        public virtual Product product { get; set; }
    }
}
