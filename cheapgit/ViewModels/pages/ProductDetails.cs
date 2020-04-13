using cheapgit.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace cheapgit.ViewModels.pages
{
    public class ProductDetails : ContentModel
    {
        public ProductDetails(IPublishedContent content) : base(content) { }

        public Product product { get; set; }


    }
}