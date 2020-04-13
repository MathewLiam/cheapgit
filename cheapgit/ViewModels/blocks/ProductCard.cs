using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Models;
using Umbraco.Core.Models;
using cheapgit.DAL.Models;
using Umbraco.Core.Models.PublishedContent;

namespace cheapgit.ViewModels.blocks
{
    public class ProductCard : ContentModel
    {
        // Standard Model Pass Through
        public ProductCard(IPublishedContent content) : base(content) { }

        public Product product { get; set; }

    }
}