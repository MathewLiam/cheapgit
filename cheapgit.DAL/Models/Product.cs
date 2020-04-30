using System;
using System.Collections.Generic;
using System.Text;

namespace cheapgit.DAL.Models
{
    public class Product
    {
        public string id { get; set; }
        public string brand { get; set; }
        public string category { get; set; }
        public string colours { get; set; }
        public DateTime? dateAdded { get; set; }
        public DateTime? dateUpdated { get; set; }
        public string dimensions { get; set; }
        public string keys { get; set; }
        public string tags { get; set; }
        public string manufacturer { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public float retailPrice { get; set; }
        public int autoExpire { get; set; }
        public DateTime? autoExpireDate { get; set; }
        public string featureBullets { get; set; }
        public int quantity { get; set; }
        public IEnumerable<string> images { get; set; }
        public IEnumerable<ProductReview> reviews { get; set; }
    }
}
