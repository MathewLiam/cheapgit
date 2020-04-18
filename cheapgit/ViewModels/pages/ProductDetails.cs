using cheapgit.DAL.Models;
using cheapgit.DAL.Workers;
using cheapgit.DAL.Workers.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace cheapgit.ViewModels.pages
{
    public class ProductDetails : ContentModel
    {
        public ProductDetails(IPublishedContent content) : base(content) { }
        public Product product { get; set; }
        public IEnumerable<ProductReview> reviews { get; set; }
    }
}